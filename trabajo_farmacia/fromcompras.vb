Imports MySqlConnector
Public Class fromcompras
    Dim idSeleccionado As Integer = 0
    Dim idLoteSeleccionado As Integer = 0
    Sub CargarCompras()
        'creo subrutina para cargar grilla
        Try
            'voy a conectar a la bd para cargar la grilla
            Using cn As New MySqlConnection(CADENA)
                cn.Open()
                'armo mi consulta sql
                Dim consulta As String = "SELECT c.id_compra, c.fecha_compra, c.numero_factura," &
                                          "p.nombre AS proveedor," &
                                           "u.nombre_usuario AS usuario," &
                                           "GROUP_CONCAT(l.codigo ORDER BY l.codigo SEPARATOR ', ') AS lotes, " &
                                           "c.id_proveedor, c.id_usuario " &
                                           "From compras As c " &
                                            "INNER Join proveedor AS p ON c.id_proveedor = p.id_proveedor " &
                                            "INNER Join usuario AS u ON c.id_usuario = u.id_usuario " &
                                           "Left Join detalle_compra AS d ON c.id_compra = d.id_compra " &
                                            "Left Join lote AS l ON d.id_lote = l.id_lote " &
                                            "GROUP BY c.id_compra, c.fecha_compra, c.numero_factura, " &
                                                     "p.nombre, u.nombre_usuario, c.id_proveedor, c.id_usuario " &
                                            "ORDER BY c.fecha_compra DESC"


                Using cmd As New MySqlCommand(consulta, cn)
                    'uso datatable para guardar un select 
                    Dim tabla As New DataTable
                    Using lector As MySqlDataReader = cmd.ExecuteReader
                        tabla.Load(lector)
                    End Using

                    'cargar la tabla en la grilla
                    dgvcompras.DataSource = tabla
                    dgvcompras.Columns("id_proveedor").Visible = False
                    dgvcompras.Columns("id_usuario").Visible = False
                    dgvcompras.Columns("fecha_compra").HeaderText = "Fecha"
                    dgvcompras.Columns("numero_factura").HeaderText = "N° de factura"
                    dgvcompras.Columns("proveedor").HeaderText = "Proveedor"
                    dgvcompras.Columns("usuario").HeaderText = "Registrado por"




                End Using

            End Using
        Catch ex As Exception
            'muestro mensaje de error
            MessageBox.Show("Error al cargar la compra: " & ex.Message)
        End Try
    End Sub



    'sub cargar los combos 
    Sub CargarCombos()
        Using cn As New MySqlConnection(CADENA)
            cn.Open()

            Dim tProv As New DataTable
            Using cmd As New MySqlCommand("SELECT id_proveedor, nombre FROM proveedor WHERE estado = 1 ORDER BY nombre", cn)
                tProv.Load(cmd.ExecuteReader())
            End Using
            cbproveedor.DisplayMember = "nombre"
            cbproveedor.ValueMember = "id_proveedor"
            cbproveedor.DataSource = tProv
            cbproveedor.SelectedIndex = -1

            Dim tUsu As New DataTable
            Using cmd As New MySqlCommand("SELECT id_usuario, nombre_usuario FROM usuario WHERE estado = 1 ORDER BY nombre_usuario", cn)
                tUsu.Load(cmd.ExecuteReader())
            End Using
            cbusuario.DisplayMember = "nombre_usuario"
            cbusuario.ValueMember = "id_usuario"
            cbusuario.DataSource = tUsu
            cbusuario.SelectedIndex = -1

            Dim tMed As New DataTable
            Using cmd As New MySqlCommand("SELECT id_medicamento, nombre FROM medicamento ORDER BY nombre", cn)
                Using lector As MySqlDataReader = cmd.ExecuteReader()
                    tMed.Load(lector)
                End Using
            End Using
            cbmedicamentos.DisplayMember = "nombre"
            cbmedicamentos.ValueMember = "id_medicamento"
            cbmedicamentos.DataSource = tMed
            cbmedicamentos.SelectedIndex = -1

        End Using
    End Sub


    'validar datos
    Function validarDatos() As Boolean
        If txtfactura.Text.Trim = "" Then
            MessageBox.Show("El número de factura es obligatorio")
            Return False
        End If
        If cbproveedor.SelectedIndex = -1 Then
            MessageBox.Show("Elegí un proveedor")
            Return False
        End If
        Return True
    End Function

    Sub limpiar()
        idSeleccionado = 0
        txtidcompras.Text = ""
        txtfactura.Text = ""
        dtpfecha.Value = Date.Today
        cbproveedor.SelectedIndex = -1
        cbusuario.SelectedIndex = -1
        cbusuario.Enabled = True
        dgvcompras.ClearSelection()
        txtlote.Text = ""
    End Sub

    ' Muestra en la grilla de abajo (dgvdetalle) los ítems de UNA compra
    Sub CargarDetalle(idCompra As Integer)
        Try
            Using cn As New MySqlConnection(CADENA)
                cn.Open()

                ' Para esa compra busco cada lote, con su medicamento, vencimiento, cantidad y precio
                Dim consulta As String = "SELECT l.codigo AS lote, m.nombre AS medicamento," &
                                     " l.fecha_vencimiento, d.cantidad, d.precio_unit" &
                                     " FROM detalle_compra AS d" &
                                     " INNER JOIN lote AS l ON d.id_lote = l.id_lote" &
                                     " INNER JOIN medicamento AS m ON l.id_medicamento = m.id_medicamento" &
                                     " WHERE d.id_compra = @id" &
                                     " ORDER BY l.codigo"

                Using cmd As New MySqlCommand(consulta, cn)
                    cmd.Parameters.AddWithValue("@id", idCompra)   ' el id de la compra elegida

                    Dim tabla As New DataTable                      ' tabla en memoria
                    Using lector As MySqlDataReader = cmd.ExecuteReader()
                        tabla.Load(lector)                          ' paso el resultado a la tabla
                    End Using

                    dgvdetalle.DataSource = tabla                   ' lo muestro en la grilla
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al cargar los ítems: " & ex.Message)
        End Try
    End Sub


    Sub PintarVencimientos(dgv As DataGridView)
        For Each fila As DataGridViewRow In dgv.Rows
            Dim venc As Date = CDate(fila.Cells("fecha_vencimiento").Value)
            If venc < Date.Today Then
                fila.DefaultCellStyle.BackColor = Color.FromArgb(248, 215, 218)    ' vencido: rojo claro
            ElseIf venc <= Date.Today.AddDays(30) Then
                fila.DefaultCellStyle.BackColor = Color.FromArgb(255, 243, 205)    ' vence en 30 días: amarillo claro
            End If
        Next
    End Sub

    Private Sub dgvcompras_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvcompras.CellContentClick

    End Sub

    'grilla
    Private Sub dgvcompras_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvcompras.CellClick
        ' Si hiciste clic en el encabezado, RowIndex vale -1 (no hay fila): salgo sin hacer nada
        If e.RowIndex < 0 Then Exit Sub

        ' "fila" es la fila de la grilla donde hiciste clic
        Dim fila As DataGridViewRow = dgvcompras.Rows(e.RowIndex)

        ' Guardo el id para saber qué compra modificar después
        idSeleccionado = CInt(fila.Cells("id_compra").Value)

        ' Paso los datos de la fila a los controles.
        ' El texto entre comillas es el nombre de la columna tal como sale del SELECT
        txtidcompras.Text = fila.Cells("id_compra").Value.ToString()
        txtfactura.Text = fila.Cells("numero_factura").Value.ToString()
        txtlote.Text = fila.Cells("lotes").Value.ToString()
        dtpfecha.Value = CDate(fila.Cells("fecha_compra").Value)   ' el calendario se posiciona en esa fecha

        ' Los combos se posicionan por el id (el ValueMember), no por el nombre
        cbproveedor.SelectedValue = CInt(fila.Cells("id_proveedor").Value)
        cbusuario.SelectedValue = CInt(fila.Cells("id_usuario").Value)

        ' Al modificar no se cambia quién registró la compra: bloqueo ese combo
        cbusuario.Enabled = False

        ' muestro los ítems de esta compra
        CargarDetalle(idSeleccionado)
    End Sub


    Private Sub fromcompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CargarCompras()
        CargarCombos()

        Estilos.EstilizarGrilla(dgvcompras)
        Estilos.EstilizarGrilla(dgvdetalle)

        Me.BackColor = Color.FromArgb(244, 247, 246)
        Estilos.EstilizarCampos(Me)

        'estiliza el group 
        EstilizarGroupBox(gbcompras)

        'estiliza los botones 
        'estiliza los botones 
        EstilizarBoton(btnregistrar, ColorMenu)
        EstilizarBoton(btnmodificar, Color.FromArgb(210, 85, 95))
        EstilizarBoton(btnlimpiar, Color.FromArgb(90, 160, 145))
        EstilizarBoton(btnagregaritem, ColorMenu)

        dgvdetalle.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvdetalle.MultiSelect = False
        dgvdetalle.AllowUserToAddRows = False
        dgvdetalle.ReadOnly = True
    End Sub



    Private Sub btnregistrar_Click(sender As Object, e As EventArgs) Handles btnregistrar.Click
        ' Si hay una fila seleccionada, estarías duplicando una compra existente
        If idSeleccionado <> 0 Then
            MessageBox.Show("Hay una compra seleccionada. ")
            Exit Sub
        End If

        If Not validarDatos() Then Exit Sub   ' si falta algo, corto acá

        If cbusuario.SelectedIndex = -1 Then  ' en el alta, el usuario también es obligatorio
            MessageBox.Show("Elegí el usuario que registra la compra")
            Exit Sub
        End If

        Try
            Using cn As New MySqlConnection(CADENA)
                cn.Open()
                ' Los @algo son parámetros: se completan abajo. Evitan errores y la inyección SQL
                Dim consulta As String = "INSERT INTO compras (fecha_compra, numero_factura, id_usuario, id_proveedor)" &
                                     " VALUES (@fecha, @factura, @usuario, @proveedor)"
                Using cmd As New MySqlCommand(consulta, cn)
                    cmd.Parameters.AddWithValue("@fecha", dtpfecha.Value.Date)                    ' la fecha del calendario, sin hora
                    cmd.Parameters.AddWithValue("@factura", txtfactura.Text.Trim)
                    cmd.Parameters.AddWithValue("@usuario", CInt(cbusuario.SelectedValue))        ' el id del usuario elegido
                    cmd.Parameters.AddWithValue("@proveedor", CInt(cbproveedor.SelectedValue))    ' el id del proveedor elegido
                    cmd.ExecuteNonQuery()                                                         ' ejecuta el INSERT
                End Using
            End Using

            MessageBox.Show("Compra registrada correctamente")
            CargarCompras()   ' recarga la grilla para ver la compra nueva
            limpiar()         ' deja el formulario listo para otra

        Catch ex As MySqlException
            If ex.Number = 1062 Then   ' 1062 = valor duplicado 
                MessageBox.Show("Ya existe una compra con ese número de factura para ese proveedor")
            Else
                MessageBox.Show("Error al registrar: " & ex.Message)
            End If
        End Try

    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        ' Sin fila seleccionada no sé cuál compra modificar
        If idSeleccionado = 0 Then
            MessageBox.Show("Seleccioná una compra de la grilla primero")
            Exit Sub
        End If

        If Not validarDatos() Then Exit Sub

        Try
            Using cn As New MySqlConnection(CADENA)
                cn.Open()
                ' UPDATE cambia los datos de UNA compra: la del WHERE id_compra = @id
                ' No incluye id_usuario: la compra queda a nombre de quien la registró
                Dim consulta As String = "UPDATE compras SET fecha_compra=@fecha, numero_factura=@factura," &
                                     " id_proveedor=@proveedor" &
                                     " WHERE id_compra=@id"
                Using cmd As New MySqlCommand(consulta, cn)
                    cmd.Parameters.AddWithValue("@fecha", dtpfecha.Value.Date)
                    cmd.Parameters.AddWithValue("@factura", txtfactura.Text.Trim)
                    cmd.Parameters.AddWithValue("@proveedor", CInt(cbproveedor.SelectedValue))
                    cmd.Parameters.AddWithValue("@id", idSeleccionado)   ' el id guardado en el CellClick
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Compra modificada correctamente")
            CargarCompras()
            limpiar()

        Catch ex As MySqlException
            If ex.Number = 1062 Then
                MessageBox.Show("Ya existe una compra con ese número de factura para ese proveedor")
            Else
                MessageBox.Show("Error al modificar: " & ex.Message)
            End If
        End Try
    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        limpiar()

    End Sub

    Private Sub btnagregaritem_Click(sender As Object, e As EventArgs) Handles btnagregaritem.Click
        ' Permiso por rol
        If Not seccion.PuedeRegistrarCompras() Then
            MessageBox.Show("Tu rol no tiene permiso para registrar compras")
            Exit Sub
        End If

        ' Tiene que haber una compra seleccionada: el ítem se agrega a esa compra
        If idSeleccionado = 0 Then
            MessageBox.Show("Seleccioná primero una compra de la grilla")
            Exit Sub
        End If

        ' Validaciones de los campos
        If cbmedicamentos.SelectedIndex = -1 Then
            MessageBox.Show("Elegí un medicamento")
            Exit Sub
        End If

        Dim codigoLote As Integer
        If Not Integer.TryParse(txtcodigolote.Text.Trim, codigoLote) Then
            MessageBox.Show("El código de lote tiene que ser un número")
            Exit Sub
        End If

        If dtpvencimiento.Value.Date <= Date.Today Then
            MessageBox.Show("El vencimiento tiene que ser posterior a hoy")
            Exit Sub
        End If

        If nudprecio.Value <= 0 Then
            MessageBox.Show("Ingresá el precio unitario")
            Exit Sub
        End If

        Try
            Using cn As New MySqlConnection(CADENA)
                cn.Open()
                Using tx As MySqlTransaction = cn.BeginTransaction()   ' empieza la transacción
                    Try
                        ' 1) Creo el lote con su vencimiento
                        Dim idLote As Long
                        Dim sqlLote As String = "INSERT INTO lote (codigo, fecha_vencimiento, cantidad_actual, id_medicamento)" &
                                            " VALUES (@codigo, @venc, @cant, @med)"
                        Using cmd As New MySqlCommand(sqlLote, cn, tx)
                            cmd.Parameters.AddWithValue("@codigo", codigoLote)
                            cmd.Parameters.AddWithValue("@venc", dtpvencimiento.Value.Date)
                            cmd.Parameters.AddWithValue("@cant", CInt(nudcantidad.Value))
                            cmd.Parameters.AddWithValue("@med", CInt(cbmedicamentos.SelectedValue))
                            cmd.ExecuteNonQuery()
                            idLote = cmd.LastInsertedId                ' id que generó la base para ese lote
                        End Using

                        ' 2) Creo la línea de detalle que une la compra con ese lote
                        Dim sqlDet As String = "INSERT INTO detalle_compra (cantidad, precio_unit, id_compra, id_lote)" &
                                           " VALUES (@cant, @precio, @compra, @lote)"
                        Using cmd As New MySqlCommand(sqlDet, cn, tx)
                            cmd.Parameters.AddWithValue("@cant", CInt(nudcantidad.Value))
                            cmd.Parameters.AddWithValue("@precio", nudprecio.Value)
                            cmd.Parameters.AddWithValue("@compra", idSeleccionado)
                            cmd.Parameters.AddWithValue("@lote", idLote)
                            cmd.ExecuteNonQuery()
                        End Using

                        tx.Commit()      ' los dos registros se guardan juntos
                    Catch
                        tx.Rollback()    ' si algo falló, se deshace todo
                        Throw            ' y paso el error al Catch de afuera
                    End Try
                End Using
            End Using

            MessageBox.Show("Ítem agregado correctamente")
            CargarDetalle(idSeleccionado)   ' refresca la grilla de ítems
            CargarCompras()                 ' refresca la columna "lotes" de la grilla principal

            ' Limpio los campos del ítem para cargar el siguiente
            cbmedicamentos.SelectedIndex = -1
            txtcodigolote.Text = ""
            dtpvencimiento.Value = Date.Today
            nudcantidad.Value = 1
            nudprecio.Value = 0

        Catch ex As MySqlException
            If ex.Number = 1062 Then
                MessageBox.Show("Ya existe un lote con ese código")
            Else
                MessageBox.Show("Error al agregar el ítem: " & ex.Message)
            End If
        End Try
    End Sub

    Private Sub dgvdetalle_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvdetalle.CellContentClick

    End Sub

    Private Sub dgvdetalle_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvdetalle.CellClick
        If e.RowIndex < 0 Then Exit Sub

        Dim fila As DataGridViewRow = dgvdetalle.Rows(e.RowIndex)
        idLoteSeleccionado = CInt(fila.Cells("id_lote").Value)


        Dim consulta As String = "SELECT d.id_lote, l.codigo AS lote, m.nombre AS medicamento," &
                         " l.fecha_vencimiento, d.cantidad, d.precio_unit" &
                         " FROM detalle_compra AS d" &
                         " INNER JOIN lote AS l ON d.id_lote = l.id_lote" &
                         " INNER JOIN medicamento AS m ON l.id_medicamento = m.id_medicamento" &
                         " WHERE d.id_compra = @id" &
                         " ORDER BY l.codigo"

        dgvdetalle.DataSource =
        dgvdetalle.Columns("id_lote").Visible = False
        PintarVencimientos(dgvdetalle)
    End Sub
End Class