using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
    class Playlist
    {
        private List<Song> list;
        public List<Song> List { get { return list; } }
        private int currentIndex;

        public Playlist ()
        {
            list = new List<Song>();
            currentIndex = 0;
        }
        public Song CurrentSong ()
        {
            if (list.Count > 0)
                return list[currentIndex];
            else
                throw new IndexOutOfRangeException("Невозможно получить текущую аудиозапись для пустого плейлиста!");
        }
        public void Addsong(Song newSong)
        {
            if (!list.Contains(newSong))
                list.Add(newSong);
            else
                MessageBox.Show("Такая композиция уже есть в плейлисте");
        }
        public void Addsong (string Author, string Title, string Filename)
        {
            Song newSong = new Song(Author, Title, Filename);
            if (!list.Contains(newSong))
                list.Add(newSong);
            else
                MessageBox.Show("Такая композиция уже есть в плейлисте");
        }
        public void NextSong()
        {
            if (currentIndex < list.Count-1)
                currentIndex++;
            else
                currentIndex = 0;
        }
        public void PreviosSong ()
        {
            if (currentIndex != 0)
                currentIndex--;
            else
                currentIndex = list.Count-1;
        }
        public void SongByIndex(int index)
        {
            if (index > 0 && index < list.Count)
                currentIndex = index;
            else
                MessageBox.Show("Индекс песни за рамками плейлиста");
        }    
        public void GoToStart()
        {
            currentIndex = 0;
        }
        public void DeleteSong(int index)
        {
            if (index >= 0 && index < list.Count)
                list.RemoveAt(index);
            else
                MessageBox.Show("Индекс песни за рамками плейлиста");
        }
        public void DeleteSong (Song song)
        {
            list.Remove(song);
        }
        
        public void Clean()
        {
            list.Clear();
        }
    }
}
