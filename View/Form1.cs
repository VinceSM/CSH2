using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transporte2.Interface;
using Transporte2.Model;

namespace Transporte2
{
    public partial class Form1 : Form
    {
        private Transport transport;
        private IEngine engine;
        private IDriver driver;

        public Form1()
        {
            InitializeComponent();
            OcultarComponentes();
        }

        private void OcultarComponentes()
        {
            lblConductor.Visible = false;
            lblMotor.Visible = false;
            chkBoxConductorH.Visible = false;
            chkBoxConductorR.Visible = false;
            chkBoxMotorC.Visible = false;
            chkBoxMotorE.Visible = false;
            txtVehiculoCreado.Visible = false;
            btnGuardarV.Visible = false;
        }


        private void btnVerMotores_Click(object sender, EventArgs e)
        {
            StringBuilder motoresInfo = new StringBuilder();

            motoresInfo.AppendLine(new CombustionEngine().Move("Combustible"));
            motoresInfo.AppendLine(new ElectricEngine().Move("Electrico"));

            txtMotores.Text = motoresInfo.ToString();
        }

        private void btnVerConductores_Click(object sender, EventArgs e)
        {
            StringBuilder conductoresInfo = new StringBuilder();

            conductoresInfo.AppendLine(new HumanDriver().Navigate("Humano")); 
            conductoresInfo.AppendLine(new RobotDriver().Navigate("Robot"));

            txtConductores.Text = conductoresInfo.ToString();
        }

        private void btnCrearVehiculo_Click(object sender, EventArgs e)
        {
            MostrarComponentes();
        }

        private void MostrarComponentes()
        {
            lblConductor.Visible = true;
            lblMotor.Visible = true;
            chkBoxConductorH.Visible = true;
            chkBoxConductorR.Visible = true;
            chkBoxMotorC.Visible = true;
            chkBoxMotorE.Visible = true;
            txtVehiculoCreado.Visible = true;
            btnGuardarV.Visible = true;
        }

        private void btnGuardarV_Click(object sender, EventArgs e)
        {
            ValidarInformacion();

            transport = new Transport(engine, chkBoxMotorC.Checked ?
                "Combustible" : "Electrico", driver, chkBoxConductorH.Checked ? "Humano" : "Robot");

            txtVehiculoCreado.Text = $"Vehículo creado con Motor: " +
                $"{transport.engine.Move(transport.Motor)} y " +
                $"Conductor: {transport.driver.Navigate(transport.Conductor)}";
        }

        private void ValidarInformacion()
        {
            if (chkBoxMotorC.Checked && chkBoxMotorE.Checked)
            {
                MessageBox.Show("Selecciona solo un tipo de motor.");
                return;
            }

            if (chkBoxConductorH.Checked && chkBoxConductorR.Checked)
            {
                MessageBox.Show("Selecciona solo un tipo de conductor.");
                return;
            }

            if (!chkBoxMotorC.Checked && !chkBoxMotorE.Checked)
            {
                MessageBox.Show("Selecciona un tipo de motor.");
                return;
            }

            if (!chkBoxConductorH.Checked && !chkBoxConductorR.Checked)
            {
                MessageBox.Show("Selecciona un tipo de conductor.");
                return;
            }

            // Asignar el motor
            if (chkBoxMotorC.Checked)
            {
                engine = new CombustionEngine();
            }
            else if (chkBoxMotorE.Checked)
            {
                engine = new ElectricEngine();
            }

            // Asignar el conductor
            if (chkBoxConductorH.Checked)
            {
                driver = new HumanDriver();
            }
            else if (chkBoxConductorR.Checked)
            {
                driver = new RobotDriver();
            }
        }

    }
}