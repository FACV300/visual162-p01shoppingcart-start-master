Public Class MainForm
    Private Sub lblTotal_Click(sender As Object, e As EventArgs) Handles lblTotal.Click

    End Sub

    Private Sub TableLayoutPanel2_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel2.Paint

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub BtnCom1_Click(sender As Object, e As EventArgs) Handles BtnCom1.Click
        If Lblpro1.Text = "Camisa de Algodon" Then
            PictureBox1.Image = ImageList1.Images.Item(0)
            lblTituloProducto.Text = "Camisa de Algodon"
            LblPrecios.Text = "$120"
            LblTallas.Text = "Tallas"
            Lblsml.Text = "XS  S  M  L  XL"
            lblTotal.Text = ""
        Else
            If Lblpro1.Text = "Polo Rayas Cuello Redondo" Then
                lblTituloProducto.Text = "Polo Rayas Cuello Redondo"
                LblPrecios.Text = "$ 80"
                LblTallas.Text = "Tallas"
                Lblsml.Text = "XS  S  M  L  XL"
                lblTotal.Text = ""
                PictureBox1.Image = ImageList1.Images.Item(4)
            Else
                If Lblpro1.Text = "Zapatos Oxfords" Then
                    PictureBox1.Image = ImageList1.Images.Item(8)
                    lblTituloProducto.Text = "Zapatos Oxfords"
                    LblPrecios.Text = "$120"
                    LblTallas.Text = "Tallas"
                    Lblsml.Text = "37 38 39 40 41 42"
                    lblTotal.Text = ""
                Else
                    If Lblpro1.Text = "Reloj de Acero" Then
                        PictureBox1.Image = ImageList1.Images.Item(12)
                        lblTituloProducto.Text = "Reloj de Acero"
                        LblPrecios.Text = "$ 380"
                        LblTallas.Text = "Tallas"
                        Lblsml.Text = "-"
                        lblTotal.Text = ""
                    End If

                End If
            End If
        End If
    End Sub

    Private Sub MainForm_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        lblTituloProducto.Text = "Camisa de Algodon"
        LblPrecios.Text = "$ 120"
        LblTallas.Text = "Tallas"
        Lblsml.Text = "XS  S  M  L  XL"
        lblTotal.Text = ""
        PictureBox1.Image = ImageList1.Images.Item(0)
    End Sub

    Private Sub TableLayoutPanel3_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel3.Paint

    End Sub

    Private Sub BtnHombres_Click(sender As Object, e As EventArgs) Handles BtnHombres.Click
        BtnHombres.ForeColor = Color.SteelBlue
        BtnMujeres.ForeColor = Color.Black
        BtnCalzado.ForeColor = Color.Black
        BtnAcce.ForeColor = Color.Black
        Lblpro1.Text = "Camisa de Algodon"
        Lblpre1.Text = "$ 120"
        Lblpro2.Text = "Blazer mezcla de Lana"
        Lblpre2.Text = "$ 240"
        Lblpro3.Text = "Jersey Cuello Pico"
        Lblpre3.Text = "$ 160"
        Lblpro4.Text = "Polo cuello redondeado"
        Lblpre4.Text = "$ 70"
    End Sub

    Private Sub Btnmenos1_Click(sender As Object, e As EventArgs) Handles Btnmenos1.Click
        If Lblcan1.Text > 0 Then
            Lblcan1.Text = Lblcan1.Text - 1
        Else
            Beep()
        End If
    End Sub

    Private Sub Btnmas1_Click(sender As Object, e As EventArgs) Handles Btnmas1.Click
        Lblcan1.Text = Lblcan1.Text + 1
    End Sub

    Private Sub Btnmenos2_Click(sender As Object, e As EventArgs) Handles Btnmenos2.Click
        If Lblcan2.Text > 0 Then
            Lblcan2.Text = Lblcan2.Text - 1
        Else
            Beep()
        End If
    End Sub

    Private Sub Btnmas2_Click(sender As Object, e As EventArgs) Handles Btnmas2.Click
        Lblcan2.Text = Lblcan2.Text + 1
    End Sub

    Private Sub Btnmenos3_Click(sender As Object, e As EventArgs) Handles Btnmenos3.Click
        If Lblcan3.Text > 0 Then
            Lblcan3.Text = Lblcan3.Text - 1
        Else
            Beep()
        End If
    End Sub

    Private Sub Btnmas3_Click(sender As Object, e As EventArgs) Handles Btnmas3.Click
        Lblcan3.Text = Lblcan3.Text + 1
    End Sub

    Private Sub Btnmenos4_Click(sender As Object, e As EventArgs) Handles Btnmenos4.Click
        If Lblcan4.Text > 0 Then
            Lblcan4.Text = Lblcan4.Text - 1
        Else
            Beep()
        End If
    End Sub

    Private Sub Btnmas4_Click(sender As Object, e As EventArgs) Handles Btnmas4.Click
        Lblcan4.Text = Lblcan4.Text + 1
    End Sub

    Private Sub BtnMujeres_Click(sender As Object, e As EventArgs) Handles BtnMujeres.Click
        BtnHombres.ForeColor = Color.Black
        BtnMujeres.ForeColor = Color.SteelBlue
        BtnCalzado.ForeColor = Color.Black
        BtnAcce.ForeColor = Color.Black
        Lblpro1.Text = "Polo Rayas Cuello Redondo"
        Lblpre1.Text = "$ 80"
        Lblpro2.Text = "Chompa Lana Cuello Redondo"
        Lblpre2.Text = "$ 150"
        Lblpro3.Text = "Casaca de Jean"
        Lblpre3.Text = "$ 220"
        Lblpro4.Text = "Abrigo Mezcla Lana"
        Lblpre4.Text = "$ 270"
    End Sub

    Private Sub BtnCalzado_Click(sender As Object, e As EventArgs) Handles BtnCalzado.Click
        BtnHombres.ForeColor = Color.Black
        BtnMujeres.ForeColor = Color.Black
        BtnCalzado.ForeColor = Color.SteelBlue
        BtnAcce.ForeColor = Color.Black
        Lblpro1.Text = "Zapatos Oxfords"
        Lblpre1.Text = "$ 120"
        Lblpro2.Text = "Zapatos Derby"
        Lblpre2.Text = "$ 140"
        Lblpro3.Text = "Botines"
        Lblpre3.Text = "$ 160"
        Lblpro4.Text = "Loafers"
        Lblpre4.Text = "$ 80"
    End Sub

    Private Sub BtnAcce_Click(sender As Object, e As EventArgs) Handles BtnAcce.Click
        BtnHombres.ForeColor = Color.Black
        BtnMujeres.ForeColor = Color.Black
        BtnCalzado.ForeColor = Color.Black
        BtnAcce.ForeColor = Color.SteelBlue
        Lblpro1.Text = "Reloj de Acero"
        Lblpre1.Text = "$ 380"
        Lblpro2.Text = "Cinturón de Cuero"
        Lblpre2.Text = "$ 70"
        Lblpro3.Text = "Billetera de Cuero"
        Lblpre3.Text = "$ 190"
        Lblpro4.Text = "Gorra Clasica"
        Lblpre4.Text = "$ 50"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Lblpro2.Text = "Blazer mezcla de Lana" Then
            PictureBox1.Image = ImageList1.Images.Item(1)
            lblTituloProducto.Text = "Blazer mezcla de Lana"
            LblPrecios.Text = "$ 240"
            LblTallas.Text = "Tallas"
            Lblsml.Text = "XS  S  M  L  XL"
            lblTotal.Text = ""
        Else
            If Lblpro2.Text = "Abrigo Mezcla Lana" Then
                lblTituloProducto.Text = "Abrigo Mezcla Lana"
                LblPrecios.Text = "$ 270"
                LblTallas.Text = "Tallas"
                Lblsml.Text = "XS  S  M  L  XL"
                lblTotal.Text = ""
                PictureBox1.Image = ImageList1.Images.Item(6)

            Else
                If Lblpro2.Text = "Zapatos Derby" Then
                    PictureBox1.Image = ImageList1.Images.Item(9)
                    lblTituloProducto.Text = "Zapatos Derby"
                    LblPrecios.Text = "$ 140"
                    LblTallas.Text = "Tallas"
                    Lblsml.Text = "37 38 39 40 41 42"
                    lblTotal.Text = ""
                Else
                    If Lblpro2.Text = "Cinturón de Cuero" Then
                        PictureBox1.Image = ImageList1.Images.Item(13)
                        lblTituloProducto.Text = "Reloj de Acero"
                        LblPrecios.Text = "$ 70"
                        LblTallas.Text = "Tallas"
                        Lblsml.Text = "S M L"
                        lblTotal.Text = ""
                    End If

                End If
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Lblpro3.Text = "Jersey Cuello Pico" Then
            PictureBox1.Image = ImageList1.Images.Item(2)
            lblTituloProducto.Text = "Blazer mezcla de Lana"
            LblPrecios.Text = "$ 160"
            LblTallas.Text = "Tallas"
            Lblsml.Text = "XS  S  M  L  XL"
            lblTotal.Text = ""

        Else
            If Lblpro3.Text = "Casaca de Jean" Then
                lblTituloProducto.Text = "Casaca de Jean"
                LblPrecios.Text = "$ 220"
                LblTallas.Text = "Tallas"
                Lblsml.Text = "XS  S  M  L  XL"
                lblTotal.Text = ""
                PictureBox1.Image = ImageList1.Images.Item(6)
            Else
                If Lblpro3.Text = "Botines" Then
                    PictureBox1.Image = ImageList1.Images.Item(10)
                    lblTituloProducto.Text = "Botines"
                    LblPrecios.Text = "$ 160"
                    LblTallas.Text = "Tallas"
                    Lblsml.Text = "37 38 39 40 41 42"
                    lblTotal.Text = ""

                Else
                    If Lblpro3.Text = "Billetera de Cuero" Then
                        PictureBox1.Image = ImageList1.Images.Item(14)
                        lblTituloProducto.Text = "Billetera de Cuero"
                        LblPrecios.Text = "$ 190"
                        LblTallas.Text = "Tallas"
                        Lblsml.Text = "S M L"
                        lblTotal.Text = ""

                    End If

                End If
            End If
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Lblpro4.Text = "Polo cuello redondeado" Then
            PictureBox1.Image = ImageList1.Images.Item(3)
            lblTituloProducto.Text = "Polo cuello redondeado"
            LblPrecios.Text = "$ 70"
            LblTallas.Text = "Tallas"
            Lblsml.Text = "XS  S  M  L  XL"
            lblTotal.Text = ""
            Lblpro4.Text = "Polo cuello redondeado"
            Lblpre4.Text = "$ 70"
        Else
            If Lblpro4.Text = "Abrigo Mezcla Lana" Then
                lblTituloProducto.Text = "Casaca de Jean"
                LblPrecios.Text = "$ 270"
                LblTallas.Text = "Tallas"
                Lblsml.Text = "XS  S  M  L  XL"
                lblTotal.Text = ""
                PictureBox1.Image = ImageList1.Images.Item(6)
            Else
                If Lblpro4.Text = "Botines" Then
                    PictureBox1.Image = ImageList1.Images.Item(10)
                    lblTituloProducto.Text = "Botines"
                    LblPrecios.Text = "$ 160"
                    LblTallas.Text = "Tallas"
                    Lblsml.Text = "37 38 39 40 41 42"
                    lblTotal.Text = ""

                Else
                    If Lblpro4.Text = "Billetera de Cuero" Then
                        PictureBox1.Image = ImageList1.Images.Item(14)
                        lblTituloProducto.Text = "Billetera de Cuero"
                        LblPrecios.Text = "$ 190"
                        LblTallas.Text = "Tallas"
                        Lblsml.Text = "S M L"
                        lblTotal.Text = ""

                    End If

                End If
            End If
        End If
    End Sub
End Class