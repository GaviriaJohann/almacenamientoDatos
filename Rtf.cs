using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AlmacenamientosDatos
{
    public partial class frmRtf : Form
    {
        private string documentsFolderPath;
 
        public frmRtf()
        {
            InitializeComponent();
            documentsFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmDatos frmDatos = new frmDatos();

            frmDatos.Show();

            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Obtener el texto del cuadro de texto
            string textToSave = txtTexto.Text;
            // Obtener el nombre del archivo del cuadro de texto
            string fileName = txtNombre.Text;

            if (string.IsNullOrWhiteSpace(fileName))
            {
                MessageBox.Show("Por favor, ingrese un nombre de archivo válido.");
                return;
            }

            // Obtener la ruta completa del archivo RTF
            string filePath = Path.Combine(documentsFolderPath, fileName + ".rtf");

            try
            {
                // Guardar el texto en el archivo RTF
                File.WriteAllText(filePath, textToSave);
                MessageBox.Show("Archivo RTF guardado correctamente en: " + filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el archivo RTF: " + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // Obtener el nombre del archivo del cuadro de texto
            string fileName = txtNombre.Text;

            if (string.IsNullOrWhiteSpace(fileName))
            {
                MessageBox.Show("Por favor, ingrese un nombre de archivo válido.");
                return;
            }

            // Obtener la ruta completa del archivo RTF
            string filePath = Path.Combine(documentsFolderPath, fileName + ".rtf");

            try
            {
                // Verificar si el archivo existe
                if (File.Exists(filePath))
                {
                    // Leer el contenido del archivo y mostrarlo en el cuadro de texto
                    string fileContent = File.ReadAllText(filePath);
                    txtTexto.Text = fileContent;
                }
                else
                {
                    MessageBox.Show("El archivo RTF especificado no existe.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el archivo RTF: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Obtener el nombre del archivo del cuadro de texto
            string fileName = txtNombre.Text;

            if (string.IsNullOrWhiteSpace(fileName))
            {
                MessageBox.Show("Por favor, ingrese un nombre de archivo válido.");
                return;
            }

            // Obtener la ruta completa del archivo RTF
            string filePath = Path.Combine(documentsFolderPath, fileName + ".rtf");

            try
            {
                // Verificar si el archivo existe antes de intentar eliminarlo
                if (File.Exists(filePath))
                {
                    // Eliminar el archivo RTF
                    File.Delete(filePath);
                    MessageBox.Show("Archivo RTF eliminado correctamente.");
                }
                else
                {
                    MessageBox.Show("El archivo RTF especificado no existe.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el archivo RTF: " + ex.Message);
            }
        }
    }
}
