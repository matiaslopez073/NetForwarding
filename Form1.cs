using System;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace NetForwarding
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CargarPuertosRed();
        }


        // ============================================================
        // ESTADO DE ESPERA
        // ============================================================

        private void IniciarEspera()
        {
            // Mostrar cursor de espera
            Cursor = Cursors.WaitCursor;
            UseWaitCursor = true;

            // Deshabilitar botones
            buttonAdd.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;

            // Deshabilitar campos
            cmbRedPorts.Enabled = false;
            localIp.Enabled = false;
            localPort.Enabled = false;
            externalIp.Enabled = false;
            externalPort.Enabled = false;
        }


        private void FinalizarEspera()
        {
            // Restaurar cursor normal
            UseWaitCursor = false;
            Cursor = Cursors.Default;

            // Habilitar botones
            buttonAdd.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;

            // Habilitar campos
            cmbRedPorts.Enabled = true;
            localIp.Enabled = true;
            localPort.Enabled = true;
            externalIp.Enabled = true;
            externalPort.Enabled = true;
        }


        // ============================================================
        // BOTON AGREGAR NUEVA REGLA
        // ============================================================

        private async void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Activar estado de espera
                IniciarEspera();


                // Verificar que exista una interfaz seleccionada
                if (cmbRedPorts.SelectedItem == null)
                {
                    richTextBox1.Text =
                        "Debe seleccionar una interfaz de red.";

                    return;
                }


                string interfaz =
                    cmbRedPorts.SelectedItem.ToString();

                // Validar direcciones IP
                if (!EsIPv4Valida(localIp.Text))
                {
                    MessageBox.Show(
                    "Ingrese una dirección IPv4 válida.",
                    "Dirección IP incorrecta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                    localIp.Focus();
                    return;
                }

                if (!EsIPv4Valida(externalIp.Text))
                {
                    MessageBox.Show(
                    "Ingrese una dirección IPv4 válida.",
                    "Dirección IP incorrecta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                    externalIp.Focus();
                    return;
                }


                // Agregar dirección IP a la interfaz
                string addNetPort = @"netsh interface ipv4 add address '" + cmbRedPorts.SelectedItem.ToString() + "' " + localIp.Text + " 255.255.255.255";

                // Crear regla PortProxy
                string addRule = "netsh interface portproxy add v4tov4 listenaddress=" + localIp.Text + " listenport=" + localPort.Text + " connectaddress=" + externalIp.Text + " connectport =" + externalPort.Text;

                // Ejecutar comandos
                string result1 =
                    await EjecutarPowerShellAsync(addNetPort);

                string result2 =
                    await EjecutarPowerShellAsync(addRule);


                // Verificar resultado
                if (string.IsNullOrWhiteSpace(result1 + result2))
                {
                    // Mostrar las reglas actuales
                    richTextBox1.Text =
                        await EjecutarPowerShellAsync(
                            "netsh interface portproxy show all");
                }
                else
                {
                    richTextBox1.Text =
                        "Error al generar la regla nueva" +
                        Environment.NewLine +
                        Environment.NewLine +
                        "Agregar dirección IP:" +
                        Environment.NewLine +
                        result1 +
                        Environment.NewLine +
                        Environment.NewLine +
                        "Agregar PortProxy:" +
                        Environment.NewLine +
                        result2;
                }
            }
            catch (Exception ex)
            {
                richTextBox1.Text =
                    "Error al generar la regla:" +
                    Environment.NewLine +
                    Environment.NewLine +
                    ex.Message;
            }
            finally
            {
                // Siempre restaurar el formulario
                FinalizarEspera();
            }
        }


        // ============================================================
        // BUTTON VIEW RULES
        // ============================================================

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Activar estado de espera
                IniciarEspera();


                string result =
                    await EjecutarPowerShellAsync(
                        "netsh interface portproxy show all");


                if (string.IsNullOrWhiteSpace(result))
                {
                    richTextBox1.Text =
                        "No existen reglas de redireccionamiento de puertos";
                }
                else
                {
                    richTextBox1.Text = result;
                }
            }
            catch (Exception ex)
            {
                richTextBox1.Text =
                    "Error al obtener las reglas:" +
                    Environment.NewLine +
                    Environment.NewLine +
                    ex.Message;
            }
            finally
            {
                // Siempre restaurar el formulario
                FinalizarEspera();
            }
        }


        // ============================================================
        // BOTON ELIMINAR REGLAS
        // ============================================================

        private async void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Activar estado de espera
                IniciarEspera();


                // Verificar que exista una interfaz seleccionada
                if (cmbRedPorts.SelectedItem == null)
                {
                    richTextBox1.Text =
                        "Debe seleccionar una interfaz de red.";

                    return;
                }


                string interfaz =
                    cmbRedPorts.SelectedItem.ToString();


                // Eliminar reglas PortProxy
                string result1 =
                    await EjecutarPowerShellAsync(
                        "netsh interface portproxy reset");


                // Eliminar direcciones IP
                string result2 =
                    await EjecutarPowerShellAsync(@"Remove-NetIPAddress -InterfaceAlias '" + cmbRedPorts.SelectedItem.ToString() + "'  -Confirm:$false");


                // Mostrar resultado
                if (string.IsNullOrWhiteSpace(result1 + result2))
                {
                    richTextBox1.Text =
                        "Las reglas fueron eliminadas correctamente";
                }
                else
                {
                    richTextBox1.Text =
                        result1 +
                        Environment.NewLine +
                        result2;
                }
            }
            catch (Exception ex)
            {
                richTextBox1.Text =
                    "Error al eliminar las reglas:" +
                    Environment.NewLine +
                    Environment.NewLine +
                    ex.Message;
            }
            finally
            {
                // Siempre restaurar el formulario
                FinalizarEspera();
            }
        }


        // ============================================================
        // BOTON LIMPIAR CONSOLA
        // ============================================================

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }


        // ============================================================
        // OBTENER INTERFACES DE RED
        // ============================================================

        private void CargarPuertosRed()
        {
            cmbRedPorts.Items.Clear();


            NetworkInterface[] interfaces =
                NetworkInterface.GetAllNetworkInterfaces();


            foreach (NetworkInterface nic in interfaces)
            {
                // No mostrar Loopback
                if (nic.NetworkInterfaceType ==
                    NetworkInterfaceType.Loopback)
                {
                    continue;
                }


                cmbRedPorts.Items.Add(nic.Name);
            }

            try
            {
                cmbRedPorts.SelectedIndex = Properties.Settings.Default.NetPort;
            }
            catch (Exception ex)
            {
                if (cmbRedPorts.Items.Count > 0)
                {
                    cmbRedPorts.SelectedIndex = 0;
                }
            }

        }

        private void cmbRedPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.NetPort = cmbRedPorts.SelectedIndex;
            Properties.Settings.Default.Save();
          
        }


        // ============================================================
        // EJECUTAR COMANDO POWERSHELL
        // ============================================================

        public async Task<string> EjecutarPowerShellAsync(string comando)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "powershell.exe",

                Arguments =
                    $"-NoProfile -ExecutionPolicy Bypass -Command \"{comando}\"",

                UseShellExecute = false,

                RedirectStandardOutput = true,
                RedirectStandardError = true,

                CreateNoWindow = true,

                StandardOutputEncoding = Encoding.UTF8,
                StandardErrorEncoding = Encoding.UTF8
            };


            using (Process proceso = new Process())
            {
                proceso.StartInfo = psi;


                // Iniciar PowerShell
                proceso.Start();


                // Leer salida estándar
                string salida =
                    await proceso.StandardOutput.ReadToEndAsync();


                // Leer errores
                string error =
                    await proceso.StandardError.ReadToEndAsync();


                // Esperar finalización del proceso
                await Task.Run(() => proceso.WaitForExit());


                // Si PowerShell produjo un error
                if (!string.IsNullOrWhiteSpace(error))
                {
                    return
                        salida +
                        Environment.NewLine +
                        "ERROR:" +
                        Environment.NewLine +
                        error;
                }


                return salida;
            }

        }

        // ============================================================
        // CHEQUEO DE IP VÁLIDA
        // ============================================================

        private bool EsIPv4Valida(string texto)
        {
            if (IPAddress.TryParse(texto, out IPAddress direccion))
            {
                return direccion.AddressFamily == AddressFamily.InterNetwork;
            }

            return false;
        }


    }
}

