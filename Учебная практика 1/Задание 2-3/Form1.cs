using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание_2
{
    public partial class Form1 :Form
    {
        public Form1 ()
        {
            InitializeComponent();
        }

        //Задание 2
        Shop pyaterochka = new Shop();
        private void addProduct_Click (object sender, EventArgs e)
        {
            if (productName.Text != "" && price.Value != 0 && addProductCount.Value != 0)
            {
                Product product = new Product(productName.Text, price.Value);
                pyaterochka.AddProduct(product, (int) addProductCount.Value);
                ShowShopList();
                //ShopList.Items.Add($"{product.Name} {(int) addProductCount.Value}шт.");
            }
        }
        private void ShowShopList()
        {
            ShopList.Items.Clear();
            ShopList.Items.AddRange(pyaterochka.Producs.Keys.Select(x=>$"{x.Name} {x.Price} руб. {pyaterochka.Producs[x]} шт.").ToArray());
            Money.Text = $"Счет: {pyaterochka.Money}";
        }
        private void sell_Click (object sender, EventArgs e)
        {
            if (sellingProduct.Text != "" && sellingCount.Value != 0)
            { 
                pyaterochka.Sell(sellingProduct.Text, (int)sellingCount.Value);

                ShowShopList();
            }
        }

        //Задание 3
        Playlist playlist = new Playlist();
        private void addSong_Click (object sender, EventArgs e)
        {
            if (authorName.Text != "" && songName.Text != "" && pathOfSong.Text != "")
            {
                bool exist = false;
                foreach (Song song in playlist.List)
                    if (song.Title == songName.Text &&
                        song.Filename == pathOfSong.Text &&
                        song.Author == authorName.Text)
                    {
                        exist=true;
                        break;
                    }

                if (exist)
                    MessageBox.Show("Уже в плейлисте");
                else
                    playlist.Addsong(authorName.Text ,songName.Text, pathOfSong.Text);

                ShowPlaylist();
            }
            else
                MessageBox.Show("Некорректный ввод");
        }
        public void ShowPlaylist()
        {
            PlaylistShow.Items.Clear();
            PlaylistShow.Items.AddRange(playlist.List.Select(x=>$"{x.Author} {x.Title} {x.Filename}").ToArray());
        }
        private void UpdateCurrentSong()
        {
            try
            {
                Song currentSong = playlist.CurrentSong();
                Track.Text = currentSong.Title + " " + currentSong.Author + " " + currentSong.Filename;
            }
            catch (IndexOutOfRangeException)
            {
                Track.Text = string.Empty;
            }
        }
        private void deleteSong_Click(object sender, EventArgs e)
        {
            if (authorName.Text != "" && songName.Text != "" && pathOfSong.Text != "")
            {
                bool exist = false;
                foreach (Song song in playlist.List)
                    if (song.Title == songName.Text &&
                        song.Filename == pathOfSong.Text &&
                        song.Author == authorName.Text)
                    {
                        playlist.DeleteSong(song);
                        exist = true;
                        break;
                    }

                if (!exist)
                    MessageBox.Show("Данной композиции нет");
                ShowPlaylist();
            }
            else
                MessageBox.Show("Некорректный ввод");
        }
        private void clearPlaylist_Click(object sender, EventArgs e)
        {
            playlist.Clean();
            ShowPlaylist();
        }
        private void deleteByIndex_Click(object sender, EventArgs e)
        {
            playlist.DeleteSong((int)indexOfSong.Value);
            ShowPlaylist();
        }
        private void previousSong_Click(object sender, EventArgs e)
        {
            playlist.PreviosSong();
            UpdateCurrentSong();
        }
        private void nextSong_Click(object sender, EventArgs e)
        {
            playlist.NextSong();
            UpdateCurrentSong();
        }
        private void toStart_Click(object sender, EventArgs e)
        {
            playlist.GoToStart();
            UpdateCurrentSong();
        }
        private void findByIndex_Click(object sender, EventArgs e)
        {
            playlist.SongByIndex((int)indexOfSong.Value);
            UpdateCurrentSong();
        }
    }
}
