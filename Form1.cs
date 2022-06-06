using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


namespace Lab3
{
    public partial class Form1 : Form
    {
        FilmList films = new FilmList();
        public Form1()
        {
            InitializeComponent();
            ChooseFilm.Items.Add(new Action());
            ChooseFilm.Items.Add(new Comedy());
            ChooseFilm.Items.Add(new Drama());
            ChooseFilm.Items.Add(new Fantasy());
            ChooseFilm.Items.Add(new Horror());

        }

        private void Add_Click(object sender, EventArgs e)
        {
            Film newFilm = ChooseFilm.SelectedItem as Film;

            newFilm.Name = NameF.Text;
            newFilm.Year = int.Parse(Year.Text);
            newFilm.Director = Director.Text;


            var film_info = string.Join(", ", newFilm.Name, newFilm.Year , "dir." , newFilm.Director);

            ShowList.Items.Add(film_info);

            films.Add(newFilm);
            

        }

        private void Edit_Click(object sender, EventArgs e)
        {

            foreach (var item in films.GetMembers())
            {
                if (ShowList.SelectedItem.ToString() == item.Name)
                {
                    item.Name = NameF.Text;
                    item.Year = int.Parse(Year.Text);
                    item.Director = Director.Text;
                    ShowList.SelectedItem = item.Name;
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {

            int index = ShowList.SelectedIndex;
            ShowList.Items.RemoveAt(index);

        }

        private void Serialize_Click(object sender, EventArgs e)
        {
            using (FileStream fileStream = new FileStream("data.dat", FileMode.OpenOrCreate))
            {
                BinaryFormatter formatter = new BinaryFormatter();

                formatter.Serialize(fileStream, films);

                ShowList.ClearSelected();
            }
        }

        private void Deserialize_Click(object sender, EventArgs e)
        {
            using (FileStream fileStream = new FileStream("data.dat",FileMode.OpenOrCreate))
            {
                BinaryFormatter formatter = new BinaryFormatter();

                films = (FilmList)formatter.Deserialize(fileStream);

                foreach (var item in films.GetMembers())
                {
                    var item_info = string.Join(", ", item.Name, item.Year, "dir.", item.Director);
                    ShowList.Items.Add(item_info);
                }
            }
        }

       

       

        private void Form1_Load(object sender, EventArgs e)
        {
            ChooseFilm.SelectedIndex = 0;
        }

       
    }
}