using NotkiAleTak.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NotkiAleTak {
    public partial class MainPage : ContentPage {
        ObservableCollection<NoteModel> note=new ObservableCollection<NoteModel>();
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
            NoteModel note = NoteList.SelectedItem as NoteModel;
            if(note != null) {
                this.note.Remove(note);
            }
        }
    }
}
