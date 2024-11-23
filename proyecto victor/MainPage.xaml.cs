using System.Collections.Generic;
using Microsoft.Maui.Controls;

namespace proyecto_victor
{
    public partial class MainPage : ContentPage
    {
        private List<string> items = new List<string>();

        public MainPage()
        {
            InitializeComponent();

            // Inicializar la lista con algunos elementos de ejemplo (opcional)
            items.Add("Agregar");
            items.Add("Borrar");

            // Enlazar la lista a un ListView
            ListView listView = new ListView();
            listView.ItemsSource = items;
            Content = listView;
        }

        private void OnAgregarClicked(object sender, EventArgs e)
        {
            // Agregar un nuevo elemento a la lista
            items.Add("Nuevo elemento");
            // Actualizar la interfaz de usuario (no es necesario en este caso simple, ya que el enlace de datos se encarga de ello)
        }

        private void OnBorrarClicked(object sender, EventArgs e)
        {
            // Eliminar el último elemento de la lista
            if (items.Count > 0)
            {
                items.RemoveAt(items.Count - 1);
            }
        }
    }
}
