using Datos;
using Negocio.Clases_por_tablas;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;

namespace Negocio.Clases_de_apoyo
{
    public static class ClsImpresionTickets
    {
        /// <summary>
        /// Arma el ticket del resumen del pedido.
        /// </summary>
        /// <param name="e">Evento que arma el ticket.</param>
        /// <param name="_ID_Pedido">Numero del pedido.</param>
        /// <param name="_EsDelivery">Para determinar si debe imprimir los datos de un delivery.</param>
        /// <param name="_DatosPedido">Array que debe contener los datos alojados en el DataGridView, como 
        /// nombre de los productos, cantidad, etc.</param>
        /// <param name="_Descuento">Cantidad de descuento.</param>
        /// <param name="_Recargo">Cantidad de aumento.</param>
        /// <param name="_Total">Total a pagar.</param>
        /// <param name="_TotalAumento">Total a aumentar.</param>
        /// <param name="_TotalDescuento">Total a descontar.</param>
        /// <param name="_Porcentaje">Porcentaje que se aplico.</param>
        /// <param name="_InformacionDelError">Devuelve una cadena de texto con informacion para el usuario en caso de que el
        /// metodo devuelva null (debido a que ocurrio un error).</param>
        /// <returns>El evento armado.</returns>
        public static void TicketResumenPedido(ref PrintPageEventArgs e, int _ID_Pedido, bool _EsDelivery, string[,] _DatosPedido, bool _Descuento, bool _Recargo, string _Total, string _TotalAumento, string _TotalDescuento, string _Porcentaje, ref string _InformacionDelError)
        {
            try
            {
                string InformacionDelError = string.Empty;

                ClsInformacionesRestaurantes InformacionesRestaurantes = new ClsInformacionesRestaurantes();
                InformacionRestaurante BuscarDatosRestaurante = InformacionesRestaurantes.LeerPorNumero(1, ref InformacionDelError);

                Font FuenteCuerpo = new Font("Arial", 7, FontStyle.Regular, GraphicsUnit.Point);
                Font FuenteTituloCuerpo = new Font("Arial", 7, FontStyle.Bold, GraphicsUnit.Point);
                Font FuenteEncabezadoPie = new Font("Arial", 10, FontStyle.Bold, GraphicsUnit.Point);
                Font FuenteEncabezadoPieSimple = new Font("Arial", 7, FontStyle.Bold, GraphicsUnit.Point);
                Font FuenteNombreRestaurante = new Font("Arial", 20, FontStyle.Bold, GraphicsUnit.Point);
                SolidBrush Pincel = new SolidBrush(Color.Black);

                int AlturaFuente = (int)FuenteCuerpo.GetHeight();
                int ComienzoX = 5;
                int ComienzoY = 0;
                int Compensar = 40;
                int SubCompensar = 3;

                if (BuscarDatosRestaurante != null)
                {
                    int PosicionX = 10;

                    if (BuscarDatosRestaurante.Nombre.Length >= 11 && BuscarDatosRestaurante.Nombre.Length < 16)
                    {
                        FuenteNombreRestaurante = new Font("Arial", 14, FontStyle.Bold, GraphicsUnit.Point);
                    }
                    else if (BuscarDatosRestaurante.Nombre.Length >= 16)
                    {
                        FuenteNombreRestaurante = new Font("Arial", 10, FontStyle.Bold, GraphicsUnit.Point);
                    }

                    switch (BuscarDatosRestaurante.Nombre.Length)
                    {
                        case 3: PosicionX = 63; break;
                        case 4: PosicionX = 53; break;
                        case 5: PosicionX = 48; break;
                        case 6: PosicionX = 36; break;
                        case 7: PosicionX = 27; break;
                        case 8: PosicionX = 18; break;
                        case 9: PosicionX = 10; break;
                        case 10: PosicionX = 5; break;
                        case 11: PosicionX = 20; break;
                        case 12: PosicionX = 18; break;
                        case 13: PosicionX = 14; break;
                        case 14: PosicionX = 12; break;
                        case 15: PosicionX = 10; break;
                        case 16: PosicionX = 20; break;
                        case 17: PosicionX = 18; break;
                        case 18: PosicionX = 16; break;
                        case 19: PosicionX = 14; break;
                        case 20: PosicionX = 12; break;
                    }

                    e.Graphics.DrawString(BuscarDatosRestaurante.Nombre, FuenteNombreRestaurante, Pincel, PosicionX, ComienzoY);

                    if (BuscarDatosRestaurante.Eslogan != null)
                    {
                        e.Graphics.DrawString($"  {BuscarDatosRestaurante.Eslogan}", FuenteEncabezadoPie, Pincel, ComienzoX, ComienzoY + FuenteNombreRestaurante.GetHeight());
                        Compensar += AlturaFuente + SubCompensar;
                    }
                }

                string NombreMozo = string.Empty;
                int MesasAcumuladas = 0;
                string LineaUnoMesas = string.Empty;
                string lineaDosMesas = string.Empty;

                ClsPedidosXMesas PedidosXMesas = new ClsPedidosXMesas();
                List<PedidoXMesa> BuscarDatos = PedidosXMesas.LeerListado(ClsPedidosXMesas.ETipoDeListado.BuscarMesasYMozo, ref InformacionDelError, _ID_Pedido);

                if (BuscarDatos != null)
                {
                    if (BuscarDatos.Count > 0 && !_EsDelivery)
                    {
                        foreach (PedidoXMesa Elemento in BuscarDatos)
                        {
                            if (MesasAcumuladas < 7)
                            {
                                LineaUnoMesas += Elemento.Mesa.Numero + "-";
                            }
                            else
                            {
                                lineaDosMesas += Elemento.Mesa.Numero + "-";
                            }

                            NombreMozo = $"{Elemento.Mesa.Usuario.Nombre} {Elemento.Mesa.Usuario.Apellido}";

                            MesasAcumuladas++;
                        }

                        LineaUnoMesas = LineaUnoMesas.Remove(LineaUnoMesas.Length - 1, 1);

                        if (lineaDosMesas != string.Empty)
                        {
                            lineaDosMesas = lineaDosMesas.Remove(lineaDosMesas.Length - 1, 1);
                        }
                    }
                }

                e.Graphics.DrawString($"Fecha: {DateTime.Now.ToShortDateString()}  Hora: {DateTime.Now.ToString(@"HH\:mm")}", FuenteEncabezadoPieSimple, Pincel, ComienzoX, ComienzoY + Compensar);
                Compensar += AlturaFuente + SubCompensar * 2;

                if (BuscarDatosRestaurante != null)
                {
                    e.Graphics.DrawString($"Direccion: {BuscarDatosRestaurante.Direccion}", FuenteEncabezadoPieSimple, Pincel, ComienzoX, ComienzoY + Compensar);
                    Compensar += AlturaFuente + SubCompensar;

                    if (BuscarDatosRestaurante.TelefonoDos == null)
                    {
                        e.Graphics.DrawString($"Contacto: {BuscarDatosRestaurante.TelefonoUno}", FuenteEncabezadoPieSimple, Pincel, ComienzoX, ComienzoY + Compensar);
                        Compensar += AlturaFuente + SubCompensar * 2;
                    }
                    else
                    {
                        e.Graphics.DrawString($"Contactos: {BuscarDatosRestaurante.TelefonoUno} / {BuscarDatosRestaurante.TelefonoDos}", FuenteEncabezadoPieSimple, Pincel, ComienzoX, ComienzoY + Compensar);
                        Compensar += AlturaFuente + SubCompensar * 2;
                    }
                }

                if (BuscarDatos != null)
                {
                    if (BuscarDatos.Count > 0 && !_EsDelivery)
                    {
                        e.Graphics.DrawString($"Mozo: {NombreMozo}", FuenteTituloCuerpo, Pincel, ComienzoX, ComienzoY + Compensar);
                        Compensar += AlturaFuente + SubCompensar;

                        e.Graphics.DrawString($"Mesa/s: {LineaUnoMesas}", FuenteTituloCuerpo, Pincel, ComienzoX, ComienzoY + Compensar);

                        if (lineaDosMesas != string.Empty)
                        {
                            Compensar += AlturaFuente + SubCompensar;

                            e.Graphics.DrawString($"{lineaDosMesas}", FuenteTituloCuerpo, Pincel, ComienzoX, ComienzoY + Compensar);
                            Compensar += AlturaFuente + SubCompensar * 2;
                        }
                        else
                        {
                            Compensar += AlturaFuente + SubCompensar * 2;
                        }
                    }
                    else
                    {
                        ClsPedidos Pedidos = new ClsPedidos();
                        Pedido BuscarPedido = Pedidos.LeerPorNumero(_ID_Pedido, ref InformacionDelError);

                        if (BuscarPedido != null)
                        {
                            if (BuscarPedido.ID_Delivery != null)
                            {
                                e.Graphics.DrawString($"Destino: {BuscarPedido.Delivery.Destino}", FuenteTituloCuerpo, Pincel, ComienzoX, ComienzoY + Compensar);
                                Compensar += AlturaFuente + SubCompensar;
                                e.Graphics.DrawString($"Cliente: {BuscarPedido.Cliente.Nombre} {BuscarPedido.Cliente.Apellido}", FuenteTituloCuerpo, Pincel, ComienzoX, ComienzoY + Compensar);
                                Compensar += AlturaFuente + SubCompensar;

                                if (BuscarPedido.Cliente.Telefono != 0)
                                {
                                    e.Graphics.DrawString($"Telefono cliente: {BuscarPedido.Cliente.Telefono} {BuscarPedido.Cliente.Apellido}", FuenteTituloCuerpo, Pincel, ComienzoX, ComienzoY + Compensar);
                                    Compensar += AlturaFuente + SubCompensar * 2;
                                }
                                else
                                {
                                    Compensar += SubCompensar;
                                }
                            }
                        }
                    }
                }

                string NombreEncabezado = "Nombre";
                string CantidadEncabezado = "Cant.";
                string SubtotalEncabezado = "Subtotal";

                e.Graphics.DrawString($"{CantidadEncabezado.PadRight(6)}{NombreEncabezado.PadRight(27)}{SubtotalEncabezado.PadLeft(11)}", FuenteTituloCuerpo, Pincel, ComienzoX, ComienzoY + Compensar);
                Compensar += AlturaFuente + SubCompensar;

                for (int Indice = 0; Indice < _DatosPedido.GetLength(0); Indice++)
                {
                    e.Graphics.DrawString($"{_DatosPedido[Indice, 1].PadLeft(7)}  {_DatosPedido[Indice, 0]}", FuenteCuerpo, Pincel, ComienzoX, ComienzoY + Compensar);
                    Compensar += AlturaFuente + SubCompensar;

                    e.Graphics.DrawString($"{string.Empty.PadLeft(48, '.')}{_DatosPedido[Indice, 2]}", FuenteCuerpo, Pincel, ComienzoX, ComienzoY + Compensar);
                    Compensar += AlturaFuente + SubCompensar;
                }

                if (_Descuento)
                {
                    e.Graphics.DrawString($"Descuento  ${_TotalDescuento} ({_Porcentaje}%)", FuenteEncabezadoPieSimple, Pincel, ComienzoX, ComienzoY + Compensar);
                    Compensar += AlturaFuente + SubCompensar;
                }
                else if (_Recargo)
                {
                    e.Graphics.DrawString($"Recargo      ${_TotalAumento} ({_Porcentaje}%)", FuenteEncabezadoPieSimple, Pincel, ComienzoX, ComienzoY + Compensar);
                    Compensar += AlturaFuente + SubCompensar;
                }

                e.Graphics.DrawString($"Total      ${Convert.ToString(Math.Round(Convert.ToDouble(_Total) + Convert.ToDouble(_TotalAumento) - Convert.ToDouble(_TotalDescuento), 2))}", FuenteEncabezadoPie, Pincel, ComienzoX, ComienzoY + Compensar);
                Compensar += AlturaFuente + SubCompensar * 3;

                e.Graphics.DrawString($" TICKET NO VALIDO COMO FACTURA", FuenteEncabezadoPieSimple, Pincel, ComienzoX, ComienzoY + Compensar);
            }
            catch (Exception Error)
            {
                _InformacionDelError = $"OCURRIO UN ERROR INESPERADO AL INTENTAR LISTAR LA INFORMACIÓN: {Error.Message}\r\n\r\n" +
                $"ORIGEN DEL ERROR: {Error.StackTrace}\r\n\r\n" +
                $"OBJETO QUE GENERÓ EL ERROR: {Error.Data}\r\n\r\n\r\n" +
                $"ENVIE AL PROGRAMADOR UNA FOTO DE ESTE MENSAJE CON UNA DESCRIPCION DE LO QUE HIZO ANTES DE QUE SE GENERARÁ " +
                $"ESTE ERROR PARA QUE SEA ARREGLADO.";
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Imprime un ticket que puede ser entregado a cocina para listar los pedidos.
        /// </summary>
        /// <param name="e">Evento que arma el ticket.</param>
        /// <param name="_ID_Pedido">Numero del pedido.</param>
        /// <param name="_PlatonsSinCocinar">Objeto que contiene la lista de platos a imprimir.</param>
        /// <param name="_InformacionDelError">Devuelve una cadena de texto con informacion para el usuario en caso de que el
        /// metodo devuelva null (debido a que ocurrio un error).</param>
        public static void TicketParaCocina(ref PrintPageEventArgs e, int _ID_Pedido, List<Detalle> _PlatonsSinCocinar, ref string _InformacionDelError)
        {
            try
            {
                string InformacionDelError = string.Empty;

                ClsInformacionesRestaurantes InformacionesRestaurantes = new ClsInformacionesRestaurantes();
                InformacionRestaurante BuscarDatosRestaurante = InformacionesRestaurantes.LeerPorNumero(1, ref InformacionDelError);

                Font FuenteCuerpo = new Font("Arial", 7, FontStyle.Regular, GraphicsUnit.Point);
                Font FuenteTituloCuerpo = new Font("Arial", 7, FontStyle.Bold, GraphicsUnit.Point);
                Font FuenteEncabezadoPie = new Font("Arial", 10, FontStyle.Bold, GraphicsUnit.Point);
                Font FuenteEncabezadoPieSimple = new Font("Arial", 7, FontStyle.Bold, GraphicsUnit.Point);
                Font FuenteNombreRestaurante = new Font("Arial", 20, FontStyle.Bold, GraphicsUnit.Point);
                SolidBrush Pincel = new SolidBrush(Color.Black);

                int AlturaFuente = (int)FuenteCuerpo.GetHeight();
                int ComienzoX = 5;
                int ComienzoY = 0;
                int Compensar = 40;
                int SubCompensar = 3;

                if (BuscarDatosRestaurante != null)
                {
                    int PosicionX = 10;

                    if (BuscarDatosRestaurante.Nombre.Length >= 11 && BuscarDatosRestaurante.Nombre.Length < 16)
                    {
                        FuenteNombreRestaurante = new Font("Arial", 14, FontStyle.Bold, GraphicsUnit.Point);
                    }
                    else if (BuscarDatosRestaurante.Nombre.Length >= 16)
                    {
                        FuenteNombreRestaurante = new Font("Arial", 10, FontStyle.Bold, GraphicsUnit.Point);
                    }

                    switch (BuscarDatosRestaurante.Nombre.Length)
                    {
                        case 3: PosicionX = 63; break;
                        case 4: PosicionX = 53; break;
                        case 5: PosicionX = 48; break;
                        case 6: PosicionX = 36; break;
                        case 7: PosicionX = 27; break;
                        case 8: PosicionX = 18; break;
                        case 9: PosicionX = 10; break;
                        case 10: PosicionX = 5; break;
                        case 11: PosicionX = 20; break;
                        case 12: PosicionX = 18; break;
                        case 13: PosicionX = 14; break;
                        case 14: PosicionX = 12; break;
                        case 15: PosicionX = 10; break;
                        case 16: PosicionX = 20; break;
                        case 17: PosicionX = 18; break;
                        case 18: PosicionX = 16; break;
                        case 19: PosicionX = 14; break;
                        case 20: PosicionX = 12; break;
                    }

                    e.Graphics.DrawString(BuscarDatosRestaurante.Nombre, FuenteNombreRestaurante, Pincel, PosicionX, ComienzoY);

                    if (BuscarDatosRestaurante.Eslogan != null)
                    {
                        e.Graphics.DrawString($"  {BuscarDatosRestaurante.Eslogan}", FuenteEncabezadoPie, Pincel, ComienzoX, ComienzoY + FuenteNombreRestaurante.GetHeight());
                        Compensar += AlturaFuente + SubCompensar;
                    }
                }

                string NombreMozo = string.Empty;
                int MesasAcumuladas = 0;
                string LineaUnoMesas = string.Empty;
                string lineaDosMesas = string.Empty;
                string TextoDetalle = string.Empty;
                string[] Detalle = new string[3];

                Detalle[0] = string.Empty;
                Detalle[1] = string.Empty;
                Detalle[2] = string.Empty;

                ClsPedidosXMesas PedidosXMesas = new ClsPedidosXMesas();
                List<PedidoXMesa> BuscarDatos = PedidosXMesas.LeerListado(ClsPedidosXMesas.ETipoDeListado.BuscarMesasYMozo, ref InformacionDelError, _ID_Pedido);

                if (BuscarDatos != null)
                {
                    if (BuscarDatos.Count > 0)
                    {
                        foreach (PedidoXMesa Elemento in BuscarDatos)
                        {
                            if (MesasAcumuladas < 7)
                            {
                                LineaUnoMesas += Elemento.Mesa.Numero + "-";
                            }
                            else
                            {
                                lineaDosMesas += Elemento.Mesa.Numero + "-";
                            }

                            NombreMozo = $"{Elemento.Mesa.Usuario.Nombre} {Elemento.Mesa.Usuario.Apellido}";
                            if (Elemento.Pedido.Nota != null) { TextoDetalle = Convert.ToString(Elemento.Pedido.Nota).ToLower(); }

                            MesasAcumuladas++;
                        }

                        LineaUnoMesas = LineaUnoMesas.Remove(LineaUnoMesas.Length - 1, 1);

                        if (lineaDosMesas != string.Empty)
                        {
                            lineaDosMesas = lineaDosMesas.Remove(lineaDosMesas.Length - 1, 1);
                        }
                    }
                }

                e.Graphics.DrawString($"Fecha: {DateTime.Now.ToShortDateString()}  Hora: {DateTime.Now.ToString(@"HH\:mm")}", FuenteEncabezadoPieSimple, Pincel, ComienzoX, ComienzoY + Compensar);
                Compensar += AlturaFuente + SubCompensar * 2;

                if (BuscarDatos != null)
                {
                    if (BuscarDatos.Count > 0)
                    {
                        e.Graphics.DrawString($"Mozo: {NombreMozo}", FuenteTituloCuerpo, Pincel, ComienzoX, ComienzoY + Compensar);
                        Compensar += AlturaFuente + SubCompensar;

                        e.Graphics.DrawString($"Mesa/s: {LineaUnoMesas}", FuenteTituloCuerpo, Pincel, ComienzoX, ComienzoY + Compensar);

                        if (lineaDosMesas != string.Empty)
                        {
                            Compensar += AlturaFuente + SubCompensar;

                            e.Graphics.DrawString($"{lineaDosMesas}", FuenteTituloCuerpo, Pincel, ComienzoX, ComienzoY + Compensar);
                            Compensar += AlturaFuente + SubCompensar * 2;
                        }
                        else
                        {
                            Compensar += AlturaFuente + SubCompensar * 2;
                        }
                    }
                }

                string NombreEncabezado = "Nombre";
                string CantidadEncabezado = "Cant.";

                e.Graphics.DrawString($"{CantidadEncabezado.PadRight(6)}{NombreEncabezado.PadRight(27)}", FuenteTituloCuerpo, Pincel, ComienzoX, ComienzoY + Compensar);
                Compensar += AlturaFuente + SubCompensar;

                foreach (Detalle Elemento in _PlatonsSinCocinar)
                {
                    if (Elemento.ID_EstadoDetalle == (int)ClsEstadoDetalle.EEstadoDetalle.NoCocinado)
                    {
                        e.Graphics.DrawString($"{Convert.ToString(Elemento.Cantidad).PadLeft(7)}  {Elemento.Articulo.Nombre}", FuenteCuerpo, Pincel, ComienzoX, ComienzoY + Compensar);
                        Compensar += AlturaFuente + SubCompensar;
                    }
                    else
                    {
                        e.Graphics.DrawString($"{Convert.ToString(Elemento.CantidadAgregada).PadLeft(7)}  {Elemento.Articulo.Nombre}", FuenteCuerpo, Pincel, ComienzoX, ComienzoY + Compensar);
                        Compensar += AlturaFuente + SubCompensar;
                    }
                }

                Compensar += SubCompensar;

                if (TextoDetalle.Length <= 40)
                {
                    Detalle[0] = Convert.ToString(TextoDetalle);
                }
                else if (TextoDetalle.Length > 40 && TextoDetalle.Length <= 80)
                {
                    Detalle[0] = Convert.ToString(TextoDetalle.Substring(0, 41));
                    Detalle[1] = Convert.ToString(TextoDetalle.Substring(41));
                }
                else
                {
                    Detalle[0] = Convert.ToString(TextoDetalle.Substring(0, 41));
                    Detalle[1] = Convert.ToString(TextoDetalle.Substring(41, 40));
                    Detalle[2] = Convert.ToString(TextoDetalle.Substring(81, TextoDetalle.Length - 81));
                }

                if (Detalle[1] == string.Empty && Detalle[0] != string.Empty)
                {
                    e.Graphics.DrawString($"{Detalle[0]}", FuenteCuerpo, Pincel, ComienzoX, ComienzoY + Compensar);
                }
                else if (Detalle[2] == string.Empty && Detalle[1] != string.Empty)
                {
                    e.Graphics.DrawString($"{Detalle[0]}", FuenteCuerpo, Pincel, ComienzoX, ComienzoY + Compensar);
                    Compensar += AlturaFuente + SubCompensar;
                    e.Graphics.DrawString($"{Detalle[1]}", FuenteCuerpo, Pincel, ComienzoX, ComienzoY + Compensar);
                }
                else if (Detalle[2] != string.Empty)
                {
                    e.Graphics.DrawString($"{Detalle[0]}", FuenteCuerpo, Pincel, ComienzoX, ComienzoY + Compensar);
                    Compensar += AlturaFuente + SubCompensar;
                    e.Graphics.DrawString($"{Detalle[1]}", FuenteCuerpo, Pincel, ComienzoX, ComienzoY + Compensar);
                    Compensar += AlturaFuente + SubCompensar;
                    e.Graphics.DrawString($"{Detalle[2]}", FuenteCuerpo, Pincel, ComienzoX, ComienzoY + Compensar);
                }
            }
            catch (Exception Error)
            {
                _InformacionDelError = $"OCURRIO UN ERROR INESPERADO AL INTENTAR LISTAR LA INFORMACIÓN: {Error.Message}\r\n\r\n" +
                $"ORIGEN DEL ERROR: {Error.StackTrace}\r\n\r\n" +
                $"OBJETO QUE GENERÓ EL ERROR: {Error.Data}\r\n\r\n\r\n" +
                $"ENVIE AL PROGRAMADOR UNA FOTO DE ESTE MENSAJE CON UNA DESCRIPCION DE LO QUE HIZO ANTES DE QUE SE GENERARÁ " +
                $"ESTE ERROR PARA QUE SEA ARREGLADO.";
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Imprime un ticket de prueba.
        /// </summary>
        /// <param name="e">Evento que arma el ticket.</param>
        /// <param name="_InformacionDelError">Devuelve una cadena de texto con informacion para el usuario en caso de que el
        /// metodo devuelva null (debido a que ocurrio un error).</param>
        public static void TicketDePrueba(ref PrintPageEventArgs e, ref string _InformacionDelError)
        {
            try
            {
                string InformacionDelError = string.Empty;

                ClsInformacionesRestaurantes InformacionesRestaurantes = new ClsInformacionesRestaurantes();
                InformacionRestaurante BuscarDatosRestaurante = InformacionesRestaurantes.LeerPorNumero(1, ref InformacionDelError);

                Font FuenteCuerpo = new Font("Arial", 7, FontStyle.Regular, GraphicsUnit.Point);
                Font FuenteTituloCuerpo = new Font("Arial", 7, FontStyle.Bold, GraphicsUnit.Point);
                Font FuenteEncabezadoPie = new Font("Arial", 10, FontStyle.Bold, GraphicsUnit.Point);
                Font FuenteEncabezadoPieSimple = new Font("Arial", 7, FontStyle.Bold, GraphicsUnit.Point);
                Font FuenteNombreRestaurante = new Font("Arial", 20, FontStyle.Bold, GraphicsUnit.Point);
                SolidBrush Pincel = new SolidBrush(Color.Black);

                int AlturaFuente = (int)FuenteCuerpo.GetHeight();
                int ComienzoX = 5;
                int ComienzoY = 0;
                int Compensar = 40;
                int SubCompensar = 3;

                if (BuscarDatosRestaurante != null)
                {
                    int PosicionX = 10;

                    if (BuscarDatosRestaurante.Nombre.Length >= 11 && BuscarDatosRestaurante.Nombre.Length < 16)
                    {
                        FuenteNombreRestaurante = new Font("Arial", 14, FontStyle.Bold, GraphicsUnit.Point);
                    }
                    else if (BuscarDatosRestaurante.Nombre.Length >= 16)
                    {
                        FuenteNombreRestaurante = new Font("Arial", 10, FontStyle.Bold, GraphicsUnit.Point);
                    }

                    switch (BuscarDatosRestaurante.Nombre.Length)
                    {
                        case 3: PosicionX = 63; break;
                        case 4: PosicionX = 53; break;
                        case 5: PosicionX = 48; break;
                        case 6: PosicionX = 36; break;
                        case 7: PosicionX = 27; break;
                        case 8: PosicionX = 18; break;
                        case 9: PosicionX = 10; break;
                        case 10: PosicionX = 5; break;
                        case 11: PosicionX = 20; break;
                        case 12: PosicionX = 18; break;
                        case 13: PosicionX = 14; break;
                        case 14: PosicionX = 12; break;
                        case 15: PosicionX = 10; break;
                        case 16: PosicionX = 20; break;
                        case 17: PosicionX = 18; break;
                        case 18: PosicionX = 16; break;
                        case 19: PosicionX = 14; break;
                        case 20: PosicionX = 12; break;
                    }

                    e.Graphics.DrawString(BuscarDatosRestaurante.Nombre, FuenteNombreRestaurante, Pincel, PosicionX, ComienzoY);
                    Compensar += AlturaFuente + SubCompensar;

                    if (BuscarDatosRestaurante.Eslogan != null)
                    {
                        e.Graphics.DrawString($"  {BuscarDatosRestaurante.Eslogan}", FuenteEncabezadoPie, Pincel, ComienzoX, ComienzoY + FuenteNombreRestaurante.GetHeight());
                        Compensar += AlturaFuente + SubCompensar * 2;
                    }
                    else
                    {
                        Compensar += AlturaFuente + SubCompensar;
                    }
                }

                e.Graphics.DrawString($" IMPRESION DE PRUEBA DE TICKET", FuenteEncabezadoPieSimple, Pincel, ComienzoX, ComienzoY + Compensar);
                Compensar += AlturaFuente + SubCompensar;
                e.Graphics.DrawString($" IMPRESION DE PRUEBA DE TICKET", FuenteEncabezadoPieSimple, Pincel, ComienzoX, ComienzoY + Compensar);
                Compensar += AlturaFuente + SubCompensar;
                e.Graphics.DrawString($" IMPRESION DE PRUEBA DE TICKET", FuenteEncabezadoPieSimple, Pincel, ComienzoX, ComienzoY + Compensar);
                Compensar += AlturaFuente + SubCompensar;
                e.Graphics.DrawString($" IMPRESION DE PRUEBA DE TICKET", FuenteEncabezadoPieSimple, Pincel, ComienzoX, ComienzoY + Compensar);
                Compensar += AlturaFuente + SubCompensar;
                e.Graphics.DrawString($" IMPRESION DE PRUEBA DE TICKET", FuenteEncabezadoPieSimple, Pincel, ComienzoX, ComienzoY + Compensar);
                Compensar += AlturaFuente + SubCompensar;
            }
            catch (Exception Error)
            {
                _InformacionDelError = $"OCURRIO UN ERROR INESPERADO AL INTENTAR LISTAR LA INFORMACIÓN: {Error.Message}\r\n\r\n" +
                $"ORIGEN DEL ERROR: {Error.StackTrace}\r\n\r\n" +
                $"OBJETO QUE GENERÓ EL ERROR: {Error.Data}\r\n\r\n\r\n" +
                $"ENVIE AL PROGRAMADOR UNA FOTO DE ESTE MENSAJE CON UNA DESCRIPCION DE LO QUE HIZO ANTES DE QUE SE GENERARÁ " +
                $"ESTE ERROR PARA QUE SEA ARREGLADO.";
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Imprime un ticket de pru.
        /// </summary>
        /// <param name="e">Evento que arma el ticket.</param>
        /// <param name="_InformacionDelError">Devuelve una cadena de texto con informacion para el usuario en caso de que el
        /// metodo devuelva null (debido a que ocurrio un error).</param>
        /// <param name="_ID_PedidoImprimir">ID del pedido que se esta imprimiendo.</param>
        public static void PlatosRecienCocinados(ref PrintPageEventArgs e, ref string _InformacionDelError, int _ID_PedidoImprimir)
        {
            try
            {
                string InformacionDelError = string.Empty;

                ClsInformacionesRestaurantes InformacionesRestaurantes = new ClsInformacionesRestaurantes();
                InformacionRestaurante BuscarDatosRestaurante = InformacionesRestaurantes.LeerPorNumero(1, ref InformacionDelError);

                Font FuenteCuerpo = new Font("Arial", 7, FontStyle.Regular, GraphicsUnit.Point);
                Font FuenteTituloCuerpo = new Font("Arial", 7, FontStyle.Bold, GraphicsUnit.Point);
                Font FuenteEncabezadoPie = new Font("Arial", 10, FontStyle.Bold, GraphicsUnit.Point);
                Font FuenteEncabezadoPieSimple = new Font("Arial", 7, FontStyle.Bold, GraphicsUnit.Point);
                Font FuenteNombreRestaurante = new Font("Arial", 20, FontStyle.Bold, GraphicsUnit.Point);
                SolidBrush Pincel = new SolidBrush(Color.Black);

                int AlturaFuente = (int)FuenteCuerpo.GetHeight();
                int ComienzoX = 5;
                int ComienzoY = 0;
                int Compensar = 40;
                int SubCompensar = 3;

                if (BuscarDatosRestaurante != null)
                {
                    int PosicionX = 10;

                    if (BuscarDatosRestaurante.Nombre.Length >= 11 && BuscarDatosRestaurante.Nombre.Length < 16)
                    {
                        FuenteNombreRestaurante = new Font("Arial", 14, FontStyle.Bold, GraphicsUnit.Point);
                    }
                    else if (BuscarDatosRestaurante.Nombre.Length >= 16)
                    {
                        FuenteNombreRestaurante = new Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point);
                    }

                    switch (BuscarDatosRestaurante.Nombre.Length)
                    {
                        case 3: PosicionX = 63; break;
                        case 4: PosicionX = 53; break;
                        case 5: PosicionX = 48; break;
                        case 6: PosicionX = 36; break;
                        case 7: PosicionX = 27; break;
                        case 8: PosicionX = 18; break;
                        case 9: PosicionX = 10; break;
                        case 10: PosicionX = 5; break;
                        case 11: PosicionX = 20; break;
                        case 12: PosicionX = 18; break;
                        case 13: PosicionX = 14; break;
                        case 14: PosicionX = 12; break;
                        case 15: PosicionX = 10; break;
                        case 16: PosicionX = 20; break;
                        case 17: PosicionX = 18; break;
                        case 18: PosicionX = 16; break;
                        case 19: PosicionX = 14; break;
                        case 20: PosicionX = 12; break;
                    }

                    e.Graphics.DrawString(BuscarDatosRestaurante.Nombre, FuenteNombreRestaurante, Pincel, PosicionX, ComienzoY);

                    if (BuscarDatosRestaurante != null)
                    {
                        e.Graphics.DrawString($"   {BuscarDatosRestaurante.Eslogan}", FuenteEncabezadoPie, Pincel, ComienzoX, ComienzoY + FuenteNombreRestaurante.GetHeight());
                        Compensar += AlturaFuente + SubCompensar;
                    }
                }

                e.Graphics.DrawString($"Fecha: {DateTime.Now.ToShortDateString()}  Hora: {DateTime.Now.ToString(@"HH\:mm")}", FuenteEncabezadoPieSimple, Pincel, ComienzoX, ComienzoY + Compensar);
                Compensar += AlturaFuente + SubCompensar * 2;

                string NombreEncabezado = "Nombre";
                string CantidadEncabezado = "Cant.";

                ClsPedidos Pedidos = new ClsPedidos();
                Pedido BuscarCliente;

                if (_ID_PedidoImprimir != -1)
                {
                    BuscarCliente = Pedidos.LeerPorNumero(_ID_PedidoImprimir, ref InformacionDelError);

                    if (BuscarCliente != null)
                    {
                        e.Graphics.DrawString($"Cliente: {BuscarCliente.Cliente.Nombre} {BuscarCliente.Cliente.Apellido}", FuenteTituloCuerpo, Pincel, ComienzoX, ComienzoY + Compensar);
                        Compensar += AlturaFuente + SubCompensar;

                        e.Graphics.DrawString($"Telefono cliente: {Convert.ToString(BuscarCliente.Cliente.Telefono)}", FuenteTituloCuerpo, Pincel, ComienzoX, ComienzoY + Compensar);
                        Compensar += AlturaFuente + SubCompensar;

                        if (BuscarCliente.Delivery.Destino == null)
                        {
                            e.Graphics.DrawString($"Direccion: Retira en el local", FuenteTituloCuerpo, Pincel, ComienzoX, ComienzoY + Compensar);
                            Compensar += AlturaFuente + SubCompensar * 2;
                        }
                        else
                        {
                            e.Graphics.DrawString($"Dir.:{BuscarCliente.Delivery.Destino}", FuenteTituloCuerpo, Pincel, ComienzoX, ComienzoY + Compensar);
                            Compensar += AlturaFuente + SubCompensar * 2;
                        }
                    }
                }

                e.Graphics.DrawString($"{CantidadEncabezado.PadRight(6)}{NombreEncabezado.PadRight(27)}", FuenteTituloCuerpo, Pincel, ComienzoX, ComienzoY + Compensar);
                Compensar += AlturaFuente + SubCompensar;

                if (_ID_PedidoImprimir != -1)
                {
                    ClsDetalles Detalles = new ClsDetalles();
                    List<Detalle> Articulos = Detalles.LeerListado(_ID_PedidoImprimir, ClsDetalles.ETipoDeListado.PorIDPedido, ref InformacionDelError);

                    if (Articulos != null)
                    {
                        foreach (Detalle Elemento in Articulos)
                        {
                            string Nombre = Elemento.Articulo.Nombre;
                            string Cantidad = Convert.ToString(Elemento.Cantidad + Elemento.CantidadAgregada);

                            e.Graphics.DrawString($"{Cantidad.PadLeft(7)}  {Nombre}", FuenteCuerpo, Pincel, ComienzoX, ComienzoY + Compensar);
                            Compensar += AlturaFuente + SubCompensar;
                        }
                    }
                }
            }
            catch (Exception Error)
            {
                _InformacionDelError = $"OCURRIO UN ERROR INESPERADO AL INTENTAR LISTAR LA INFORMACIÓN: {Error.Message}\r\n\r\n" +
                $"ORIGEN DEL ERROR: {Error.StackTrace}\r\n\r\n" +
                $"OBJETO QUE GENERÓ EL ERROR: {Error.Data}\r\n\r\n\r\n" +
                $"ENVIE AL PROGRAMADOR UNA FOTO DE ESTE MENSAJE CON UNA DESCRIPCION DE LO QUE HIZO ANTES DE QUE SE GENERARÁ " +
                $"ESTE ERROR PARA QUE SEA ARREGLADO.";
                e.Cancel = true;
            }
        }
    }
}
