using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using TPG3.Entidades;
using TPG3.AccesoADatos;
using TPG3.CapaLogicaNegocio;

namespace TPG3
{
    public partial class Main : Form
    {
        private static Form currentForm = null; 
        internal static Main main1;
        public Usuario usuario;
        public Main()
        {
            InitializeComponent();
            hideSubMenu();
            main1 = this;
            //usuario = user;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void displayLogIn()
        {
            Form logIn = new LogIn();
            logIn.ShowDialog();
        }
        private void openChildForm(Form childForm)
        {
            if (currentForm != null) currentForm.Close();
            currentForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void hideSubMenu()
        {
            panelSubMenuPelicula.Visible = false;
            panelSubMenuCombo.Visible = false;
            panelSubMenuEntrada.Visible = false;
            panelSubMenuFuncion.Visible = false;
            panelSubMenuTicket.Visible = false;
            panelSubMenuMedioPago.Visible = false;
            panelSubMenuUsuario.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false){
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnMenuPelicula_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuPelicula);
        }
        private void btnMenuCombo_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuCombo);
        }

        private void btnMenuEntrada_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuEntrada);
        }

        private void btnMenuFuncion_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuFuncion);
        }
        public void btnSubFuncionAltaFuncion(Entidades.Funcion funcion)
        {
            Formularios.Funcion.AltaFuncion altaFuncion = new Formularios.Funcion.AltaFuncion(funcion);
            openChildForm(altaFuncion);
        }

        public void btnEstadoFuncion(DateTime fechaHora, int sala, int formato)
        {
            Formularios.Funcion.EstadoFuncion estadoFuncion = new Formularios.Funcion.EstadoFuncion(fechaHora, sala, formato);
            openChildForm(estadoFuncion);
        }

        private void btnMenuTicket_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuTicket);
        }

        private void btnMenuMedioPago_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuMedioPago);
        }

        private void btnMenuUsuario_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuUsuario);
        }

        public void btnSubPromocionAltaPromocion(Entidades.Promocion promo)
        {
            Formularios.Promocion.AltaPromocion altaPromocion = new Formularios.Promocion.AltaPromocion(promo);
            openChildForm(altaPromocion);
        }

        public void btnSubPromocion_Click(object sender, EventArgs e)
        {
            Formularios.Promocion.ListaPromocion listaPromocion = new Formularios.Promocion.ListaPromocion();
            openChildForm(listaPromocion);
        }

        public void btnSubMedioPagoAltaMedioPago(Entidades.MedioPago medio)
        {
            Formularios.MedioPago.AltaMedioPago altaMedioPago = new Formularios.MedioPago.AltaMedioPago(medio);
            openChildForm(altaMedioPago);
        }

        public void btnSubMedioPago_Click(object sender, EventArgs e)
        {
            Formularios.MedioPago.ListaMedioPago listaMedioPago = new Formularios.MedioPago.ListaMedioPago();
            openChildForm(listaMedioPago);
        }

        private void btnSubTipoDocumento_Click(object sender, EventArgs e)
        {
            Formularios.TipoDocumento.ListadoTipoDocumento listaTipoDocumento = new Formularios.TipoDocumento.ListadoTipoDocumento();
            openChildForm(listaTipoDocumento);
        }

        public void btnSubEmpleado_Click(object sender, EventArgs e)
        {
            Formularios.Empleado.ListadoEmpelado listaEmpleado = new Formularios.Empleado.ListadoEmpelado();
            openChildForm(listaEmpleado);
        }
        public void btnSubTicketAltaEmpleado(Entidades.Empleado empleado)
        {
            Formularios.Empleado.AltaEmpleado altaEmpleado = new Formularios.Empleado.AltaEmpleado(empleado);
            openChildForm(altaEmpleado);
        }

        private void btnSubParticipantes_Click(object sender, EventArgs e)
        {
            Formularios.Actores.ListaActor listaActor = new Formularios.Actores.ListaActor();
            openChildForm(listaActor);
        }

        public void btnSubParticipantesAltaParticipante(object sender, EventArgs e)
        {
            Entidades.Actor actor = new Entidades.Actor(1, "", "");
            Formularios.Actores.AltaActor altaActor = new Formularios.Actores.AltaActor(actor);
            openChildForm(altaActor);
        }

        private void btnSubProducto_Click(object sender, EventArgs e)
        {
            Formularios.Producto.ListaProducto listaProducto = new Formularios.Producto.ListaProducto();
            openChildForm(listaProducto);
        }
        public void btnSubComboAltaProducto(object sender, EventArgs e)
        {
            Entidades.Producto prod = new Entidades.Producto(-1, "", "", -1, 0, 0, 1);
            Formularios.Producto.AltaProducto altaProducto = new Formularios.Producto.AltaProducto(prod);
            openChildForm(altaProducto);
        }
        public void btnSubCombo_Click(object sender, EventArgs e)
        {
            Formularios.Combo.ListaCombo listaCombo = new Formularios.Combo.ListaCombo();
            openChildForm(listaCombo);
        }
        public void btnSubComboAltaCombo(Entidades.Producto combo)
        {
            //Formularios.Combo.AltaCombo altaCombo = new Formularios.Combo.AltaCombo(combo);
            //openChildForm(altaCombo);
            Formularios.Combo.AltaCombo altaCombo = new Formularios.Combo.AltaCombo(combo);
            openChildForm(altaCombo);
        }

        private void btnSubPelicula_Click(object sender, EventArgs e)
        {
            Formularios.Pelicula.ListaPelicula listaPelicula = new Formularios.Pelicula.ListaPelicula();
            openChildForm(listaPelicula);
        }
        public void btnSubPeliculaAltaPelicula(object sender, EventArgs e)
        {
            Formularios.Pelicula.AltaPelicula altaPelicula = new Formularios.Pelicula.AltaPelicula();
            openChildForm(altaPelicula);
        }
        public void btnSubAltaTarjeta(Entidades.Tarjeta tar)
        {
            Formularios.Tarjeta.AltaTarjeta altaTarjeta = new Formularios.Tarjeta.AltaTarjeta(tar);
            openChildForm(altaTarjeta);
        }

        public void btnSubTarjeta_Click(object sender, EventArgs e)
        {
            Formularios.Tarjeta.ListaTarjeta listaTarjeta = new Formularios.Tarjeta.ListaTarjeta();
            openChildForm(listaTarjeta);
        }

        private void btnSubOrigen_Click(object sender, EventArgs e)
        {
            Formularios.Origen.ListadoOrigen listaorigen = new Formularios.Origen.ListadoOrigen();
            openChildForm(listaorigen);
        }

        private void btnSubGenero_Click(object sender, EventArgs e)
        {
            Formularios.Genero.ListadoGenero listaGenero = new Formularios.Genero.ListadoGenero();
            openChildForm(listaGenero);
        }

        private void btnSubCalificacion_Click(object sender, EventArgs e)
        {
            Formularios.Calificacion.ListadoCalificacion listadoCalificacion = new Formularios.Calificacion.ListadoCalificacion();
            openChildForm(listadoCalificacion);
        }

        private void btnSubFormato_Click(object sender, EventArgs e)
        {
            Formularios.Formato.listaFormato listaFormato = new Formularios.Formato.listaFormato();
            openChildForm(listaFormato);
        }

        private void btnSubDistribuidora_Click(object sender, EventArgs e)
        {
            Formularios.Distribuidora.ListadoDistribuidora listaDistribuidora = new Formularios.Distribuidora.ListadoDistribuidora();
            openChildForm(listaDistribuidora);
        }

        private void btnSubRol_Click(object sender, EventArgs e)
        {
            Formularios.Rol.ListadoRol listadoRol = new Formularios.Rol.ListadoRol();
            openChildForm(listadoRol);
        }

        private void btnSubTipoProducto_Click(object sender, EventArgs e)
        {
            Formularios.TipoProducto.ListaTipoProducto listaTipoProducto = new Formularios.TipoProducto.ListaTipoProducto();
            openChildForm(listaTipoProducto);
        }

        private void btnSubTarifa_Click(object sender, EventArgs e)
        {
            Formularios.Tarifa.listaTarifa listaTarifa = new Formularios.Tarifa.listaTarifa();
            openChildForm(listaTarifa);
        }

        private void btnSubSala_Click(object sender, EventArgs e)
        {
            Formularios.Sala.listadoSala listaSala = new Formularios.Sala.listadoSala();
            openChildForm(listaSala);
        }

        private void btnSubProgramacion_Click(object sender, EventArgs e)
        {
            Formularios.ProgramacionSemanal.listaProgramacionSemanal listaProgramacion = new Formularios.ProgramacionSemanal.listaProgramacionSemanal();    
            openChildForm(listaProgramacion);
        }

        private void btnSubEstado_Click(object sender, EventArgs e)
        {
            Formularios.Estado.listaEstado listaEstado = new Formularios.Estado.listaEstado();
            openChildForm(listaEstado);
        }

        public void btnFuncion_Click(object sender, EventArgs e)
        {
            Formularios.Funcion.ListaFuncion listaFuncion = new Formularios.Funcion.ListaFuncion();
            openChildForm(listaFuncion);
        }

        private void btnSubTarjeta_Click_1(object sender, EventArgs e)
        {
            Formularios.Tarjeta.ListaTarjeta listaTarjeta = new Formularios.Tarjeta.ListaTarjeta();
            openChildForm(listaTarjeta);
        }

        private void btnSubBanco_Click(object sender, EventArgs e)
        {
            Formularios.Banco.listaBanco listaBanco = new Formularios.Banco.listaBanco();
            openChildForm(listaBanco);
        }

        public void btnSubCliente_Click(object sender, EventArgs e)
        {
            Formularios.Cliente.ListadoCliente listaCliente = new Formularios.Cliente.ListadoCliente();
            openChildForm(listaCliente);
        }

        public void btnSubTicketAltaCliente(Entidades.Cliente cliente)
        {
            Formularios.Cliente.AltaCliente altaCliente = new Formularios.Cliente.AltaCliente(cliente);
            openChildForm(altaCliente);
        }

        private void btnSubUsuario_Click(object sender, EventArgs e)
        {
            Formularios.Usuario.listadoUsuario listaUsuario = new Formularios.Usuario.listadoUsuario();
            openChildForm(listaUsuario);
        }

        public void formPagoCombo(List<EditItemCombo> items)
        {
            PagoCombo pagoCombo = new PagoCombo(items);
            openChildForm(pagoCombo);
        }
        public void btnVolverSeleccionPelicula(object sender, EventArgs e)
        {
            PeliculaService seleccionPelicula = new PeliculaService();
            openChildForm(seleccionPelicula);
        }
        
        private void btnSubTicket_Click(object sender, EventArgs e)
        {
            Combo ventaCombo = new Combo();
            openChildForm(ventaCombo);
        }

        private void btnSubEntrada_Click(object sender, EventArgs e)
        {
            PeliculaService peliService = new PeliculaService();
            openChildForm(peliService);
        }

        public void formTarifa(DateTime fechaHora,int sala, int codFormato)
        {
            TarifaService tarifaService = new TarifaService(fechaHora,sala, codFormato);
            openChildForm(tarifaService);
        }
        public void formSeleccionarAsientos(DateTime fechaHora, int sala,List<int> listaCantXTarifa,List<float> listaPrecioXTarifa,int cantSolicitada, string promocion, float descPromo, int codFormato, int medioPago)
        {
            SeleccionAsientoFuncion selecAsiento = new SeleccionAsientoFuncion(fechaHora, sala,listaCantXTarifa, listaPrecioXTarifa, cantSolicitada, promocion,descPromo, codFormato, medioPago);
            openChildForm(selecAsiento);
        }

        public void btnEntradasVendidas_Click(object sender, EventArgs e)
        {
            Formularios.EntradasVendidas.ListaEntradas listaEntrada = new Formularios.EntradasVendidas.ListaEntradas();
            openChildForm(listaEntrada);
        }

        public void btnDetalleVentaEntradas(Ticket ticket, ReporteTicket reporte)
        {
            Formularios.EntradasVendidas.DetalleVentaEntradas listaDetalle = new Formularios.EntradasVendidas.DetalleVentaEntradas(ticket, reporte);
            openChildForm(listaDetalle);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Formularios.Reportes.Reportes listaReportes = new Formularios.Reportes.Reportes();
            openChildForm(listaReportes);
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            Formularios.Estadisticas.Estadisticas listaEstadisticas = new Formularios.Estadisticas.Estadisticas();
            openChildForm(listaEstadisticas);
        }
    }
}



