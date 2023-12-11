using NotkiAleTak.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NotkiAleTak {
    public partial class MainPage : ContentPage {
        List<NoteModel> note=new List<NoteModel>();
        public MainPage() {
            InitializeComponent();
            note.Add(new NoteModel() { 
                ID=Guid.NewGuid(),
                Title="Title",
            });
            note.Add(new NoteModel() {
                ID = Guid.NewGuid(),
                Title = "Title2",
            });
            NoteList.ItemsSource = note;
        }

        private void Add_Clicked(object sender, EventArgs e) {

        }

        private void Edit_Clicked(object sender, EventArgs e) {

        }

        private void Delete_Clicked(object sender, EventArgs e) {

        }
    }
}
