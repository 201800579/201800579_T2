
'importamos la libreria math ya que utilizaremos el comando round para aproximar a dos decimales
Imports System.Math


Public Class Form1

    'crearemos un espacio en memoria de tipo double para los precios Fijos que se nos presentan para cada  producto
    'en este caso seran arroz, frijol, azucar
    Dim PrecioArroz As Double = 2.0
    Dim PrecioFrijo As Double = 1.75
    Dim PrecioAzucar As Double = 2.5

    'inicia la codificacion de todas las operaciones que realizara nuestro boton calcular
    Private Sub Calcular_Click(sender As Object, e As EventArgs) Handles Calcular.Click



        'crearemos las varibles donde guardaremos los valores de nuestras operaciones y estas seran de tipo double
        ' ya que trabajareos con decimales
        Dim PrecioPagar As Double
        Dim Iva As Double
        Dim PagoconIva As Double
        Dim Descuento As Double
        Dim PagoFinal As Double


        'nuestras cajas de texto del grupo total detallado se les hizo una modificaion en la opcion de diseño
        'la cual fue de Readonly de un valor verdadero a un valor verdadero esto con el motivo porque no se espera
        'recibir ninguin tipo de informacion en ellos 

        'intrcciones por si en dando caso el usuario no ingresa libras de ninguno de nuestros productos se 
        'mostrara un mensaje en una cuadro de texto

        If LbArroz.Text = 0 Then
            If LbFrijol.Text = 0 Then
                If LbAzucar.Text = 0 Then
                    MsgBox("Usted no Ingeso datos... Intente de nuevo")
                End If
            End If


        End If



        'instruccions para aplicar descuentos en dando caso sea para si o no ya quee esto cambiara nuestros totales

        If DescuentoOpcion.Text = "si" Then
            'comando str nos ayudara a convertir en un to string nuestro valor redondeado y lo enviaremos 
            'a nuestras cajas de texto 

            'en el caso de Precio a pagar sera un total parcial de nuestro total ya que este aun no incluye el iva 
            'ni el descuento pero de esta operacion partiremos hacia las demas hasta llegar a nuestro total absoluto
            PrecioPagar = (PrecioArroz * LbArroz.Text + PrecioFrijo * LbFrijol.Text + PrecioAzucar * LbAzucar.Text)
            PParcial.Text = ("Q. " + Str(Round(PrecioPagar, 2)))

            Iva = PrecioPagar * 0.12
            boxIVA.Text = ("Q. " + Str(Round(Iva, 2)))

            PagoconIva = PrecioPagar + Iva
            PIVA.Text = ("Q. " + Str(Round(PagoconIva, 2)))

            Descuento = PagoconIva * 0.025
            BoxDescuento.Text = ("Q. " + Str(Round(Descuento, 2)))

            PagoFinal = PagoconIva - Descuento
            TPagar.Text = ("Q. " + Str(Round(PagoFinal, 2)))



            'en dado caso que no se aplique descuento se relizran las siguientes instrucciones 
            'que seran las mismas para el si solo que quitando el valor que tomara la caja descuentos
        Else
            PrecioPagar = (PrecioArroz * LbArroz.Text + PrecioFrijo * LbFrijol.Text + PrecioAzucar * LbAzucar.Text)
            PParcial.Text = ("Q. " + Str(Round(PrecioPagar, 2)))

            Iva = PrecioPagar * 0.12
            boxIVA.Text = ("Q. " + Str(Round(Iva, 2)))

            PagoconIva = PrecioPagar + Iva
            PIVA.Text = ("Q. " + Str(Round(PagoconIva, 2)))

            Descuento = 0
            BoxDescuento.Text = ("Q. " + Str(Round(Descuento, 2)))

            PagoFinal = PagoconIva - Descuento
            TPagar.Text = ("Q. " + Str(Round(PagoFinal, 2)))



        End If

    End Sub


    'inicia la codificacion de todas las acciones que realizara nuestro boton Limpiar cada una de as cajas de texto
    Private Sub Limpiar_Click(sender As Object, e As EventArgs) Handles Limpiar.Click
        'limpiaremos nuestras cajas de texto para que podamos realizar otraas transacciones
        LbArroz.Clear()
        LbFrijol.Clear()
        LbAzucar.Clear()
        PParcial.Clear()
        boxIVA.Clear()
        PIVA.Clear()
        BoxDescuento.Clear()
        TPagar.Clear()
        DescuentoOpcion.Clear()
        'les daremos un valor inicial de nuevo para que no queden totalmente vacias 
        LbArroz.Text() = 0
        LbFrijol.Text() = 0
        LbAzucar.Text() = 0
        PParcial.Text = "Q. 0"
        boxIVA.Text = "Q. 0"
        PIVA.Text = "Q. 0"
        BoxDescuento.Text = "Q. 0"
        TPagar.Text = "Q. 0"
        DescuentoOpcion.Text = "si/no"



    End Sub


    'inicia la codificacion de nuestro boton salir el cual nomas tendra una instruccion simple 
    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        Close()
    End Sub

    'este fragmento de codigo hara que en nuestra caja de texto destinada a las libras de arroz solo se 
    'ingresen numeros para ello utilizaremos if
    Private Sub LbArroz_KeyPress(sender As Object, e As KeyPressEventArgs) Handles LbArroz.KeyPress

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

    'este fragmento de codigo hara que en nuestra caja de texto destinada a las libras de Frijol solo se 
    'ingresen numeros para ello utilizaremos if
    Private Sub LbFrijol_KeyPress(sender As Object, e As KeyPressEventArgs) Handles LbFrijol.KeyPress

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

    'este fragmento de codigo hara que en nuestra caja de texto destinada a las libras de azucar solo se 
    'ingresen numeros para ello utilizaremos if
    Private Sub LbAzucar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles LbAzucar.KeyPress

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub
    Private Sub DescuentoOpcion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DescuentoOpcion.KeyPress

        If DescuentoOpcion.Text = "si " Then

            e.Handled = True

        End If

    End Sub






End Class
