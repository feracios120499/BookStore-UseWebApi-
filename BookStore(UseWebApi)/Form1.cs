using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore_UseWebApi_
{
    public partial class Form1 : Form
    {
        public class Book
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public override string ToString()
            {
                return $"{Id} {Name}";
            }
        }
        public class BookApi
        {
            private static string url = "http://localhost:64978/api/values";
            private static readonly HttpClient client = new HttpClient();
            public async static Task<IEnumerable<Book>> Get()
            {
                var response = await client.GetAsync(url);
                var responseString = await response.Content.ReadAsStringAsync();
                var books = JsonConvert.DeserializeObject<IEnumerable<Book>>(responseString);
                return books;
            }
            public async static Task<Book> Get(int id)
            {
                var response = await client.GetAsync(url + $"/{id}");
                var responseString = await response.Content.ReadAsStringAsync();
                var books = JsonConvert.DeserializeObject<Book>(responseString);
                return books;
            }
            public async static void Post(Book book)
            {
                var json = JsonConvert.SerializeObject(book);
                var response = await client.PostAsync(url, new StringContent(json, Encoding.UTF8, "application/json"));
            }
            public async static void Delete(int id)
            {
                await client.DeleteAsync(url + $"/{id}");
            }
            public async static void Put(int id, Book book)
            {
                var json = JsonConvert.SerializeObject(book);
                var response = await client.PutAsync(url + $"/{id}", new StringContent(json, Encoding.UTF8, "application/json"));
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void buttonGet_Click(object sender, EventArgs e)
        {
            var books = await BookApi.Get();
            listBoxGet.Items.Clear();
            foreach (var item in books)
            {
                listBoxGet.Items.Add(item);
            }

        }


        private void buttonPOST_Click(object sender, EventArgs e)
        {
            var book = new Book { Id = Convert.ToInt32(textBoxIdPOST.Text), Name = textBoxNamePOST.Text };
            BookApi.Post(book);
        }

        private void buttonPUT_Click(object sender, EventArgs e)
        {
            var book = new Book { Id = Convert.ToInt32(textBoxIdPUT.Text), Name = textBoxNamePUT.Text };
            BookApi.Put(book.Id, book);
        }

        private void buttonDELETE_Click(object sender, EventArgs e)
        {
            BookApi.Delete(Convert.ToInt32(textBoxIdDELETE.Text));
        }

        private async void buttonGetId_Click(object sender, EventArgs e)
        {
            var book = await BookApi.Get(Convert.ToInt32(textBoxGetId.Text));
            listBoxGetId.Items.Clear();

            listBoxGetId.Items.Add(book);

        }
    }
}
