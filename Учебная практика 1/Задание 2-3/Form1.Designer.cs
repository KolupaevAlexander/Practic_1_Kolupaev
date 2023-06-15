
namespace Задание_2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose (bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent ()
        {
            this.productName = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.NumericUpDown();
            this.ShopList = new System.Windows.Forms.ListBox();
            this.addProduct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Money = new System.Windows.Forms.Label();
            this.sellingProduct = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sell = new System.Windows.Forms.Button();
            this.sellingCount = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.addProductCount = new System.Windows.Forms.NumericUpDown();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.toStart = new System.Windows.Forms.Button();
            this.Track = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.indexOfSong = new System.Windows.Forms.NumericUpDown();
            this.findByIndex = new System.Windows.Forms.Button();
            this.clearPlaylist = new System.Windows.Forms.Button();
            this.nextSong = new System.Windows.Forms.Button();
            this.previousSong = new System.Windows.Forms.Button();
            this.deleteSong = new System.Windows.Forms.Button();
            this.addSong = new System.Windows.Forms.Button();
            this.pathOfSong = new System.Windows.Forms.TextBox();
            this.songName = new System.Windows.Forms.TextBox();
            this.authorName = new System.Windows.Forms.TextBox();
            this.PlaylistShow = new System.Windows.Forms.ListBox();
            this.deleteByIndex = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellingCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addProductCount)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.indexOfSong)).BeginInit();
            this.SuspendLayout();
            // 
            // productName
            // 
            this.productName.Location = new System.Drawing.Point(122, 143);
            this.productName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(178, 26);
            this.productName.TabIndex = 0;
            // 
            // price
            // 
            this.price.DecimalPlaces = 2;
            this.price.Location = new System.Drawing.Point(122, 203);
            this.price.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(180, 26);
            this.price.TabIndex = 1;
            // 
            // ShopList
            // 
            this.ShopList.FormattingEnabled = true;
            this.ShopList.ItemHeight = 20;
            this.ShopList.Location = new System.Drawing.Point(310, 143);
            this.ShopList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ShopList.Name = "ShopList";
            this.ShopList.Size = new System.Drawing.Size(283, 284);
            this.ShopList.TabIndex = 2;
            // 
            // addProduct
            // 
            this.addProduct.Location = new System.Drawing.Point(122, 317);
            this.addProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addProduct.Name = "addProduct";
            this.addProduct.Size = new System.Drawing.Size(180, 35);
            this.addProduct.TabIndex = 3;
            this.addProduct.Text = "Добавить";
            this.addProduct.UseVisualStyleBackColor = true;
            this.addProduct.Click += new System.EventHandler(this.addProduct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 118);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 178);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Цена";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(374, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Список товаров";
            // 
            // Money
            // 
            this.Money.AutoSize = true;
            this.Money.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Money.Location = new System.Drawing.Point(118, 375);
            this.Money.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Money.Name = "Money";
            this.Money.Size = new System.Drawing.Size(81, 25);
            this.Money.TabIndex = 7;
            this.Money.Text = "Счет: 0";
            // 
            // sellingProduct
            // 
            this.sellingProduct.Location = new System.Drawing.Point(604, 143);
            this.sellingProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sellingProduct.Name = "sellingProduct";
            this.sellingProduct.Size = new System.Drawing.Size(178, 26);
            this.sellingProduct.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(600, 118);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Название";
            // 
            // sell
            // 
            this.sell.Location = new System.Drawing.Point(604, 258);
            this.sell.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sell.Name = "sell";
            this.sell.Size = new System.Drawing.Size(180, 35);
            this.sell.TabIndex = 10;
            this.sell.Text = "Продать";
            this.sell.UseVisualStyleBackColor = true;
            this.sell.Click += new System.EventHandler(this.sell_Click);
            // 
            // sellingCount
            // 
            this.sellingCount.Location = new System.Drawing.Point(604, 203);
            this.sellingCount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sellingCount.Name = "sellingCount";
            this.sellingCount.Size = new System.Drawing.Size(180, 26);
            this.sellingCount.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(600, 178);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Кол-во";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(117, 238);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Кол-во";
            // 
            // addProductCount
            // 
            this.addProductCount.Location = new System.Drawing.Point(122, 263);
            this.addProductCount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addProductCount.Name = "addProductCount";
            this.addProductCount.Size = new System.Drawing.Size(180, 26);
            this.addProductCount.TabIndex = 13;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1000, 692);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ShopList);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.productName);
            this.tabPage1.Controls.Add(this.addProductCount);
            this.tabPage1.Controls.Add(this.price);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.addProduct);
            this.tabPage1.Controls.Add(this.sellingCount);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.sell);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.sellingProduct);
            this.tabPage1.Controls.Add(this.Money);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(992, 659);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Магазин";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.deleteByIndex);
            this.tabPage2.Controls.Add(this.toStart);
            this.tabPage2.Controls.Add(this.Track);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.indexOfSong);
            this.tabPage2.Controls.Add(this.findByIndex);
            this.tabPage2.Controls.Add(this.clearPlaylist);
            this.tabPage2.Controls.Add(this.nextSong);
            this.tabPage2.Controls.Add(this.previousSong);
            this.tabPage2.Controls.Add(this.deleteSong);
            this.tabPage2.Controls.Add(this.addSong);
            this.tabPage2.Controls.Add(this.pathOfSong);
            this.tabPage2.Controls.Add(this.songName);
            this.tabPage2.Controls.Add(this.authorName);
            this.tabPage2.Controls.Add(this.PlaylistShow);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(992, 659);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Плейлист";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // toStart
            // 
            this.toStart.Location = new System.Drawing.Point(27, 488);
            this.toStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.toStart.Name = "toStart";
            this.toStart.Size = new System.Drawing.Size(180, 35);
            this.toStart.TabIndex = 15;
            this.toStart.Text = "К началу";
            this.toStart.UseVisualStyleBackColor = true;
            this.toStart.Click += new System.EventHandler(this.toStart_Click);
            // 
            // Track
            // 
            this.Track.AutoSize = true;
            this.Track.Location = new System.Drawing.Point(256, 358);
            this.Track.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Track.Name = "Track";
            this.Track.Size = new System.Drawing.Size(171, 20);
            this.Track.TabIndex = 14;
            this.Track.Text = "Текущая композиция:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 149);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Путь";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 89);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Название";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 29);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Автор";
            // 
            // indexOfSong
            // 
            this.indexOfSong.Location = new System.Drawing.Point(27, 358);
            this.indexOfSong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.indexOfSong.Name = "indexOfSong";
            this.indexOfSong.Size = new System.Drawing.Size(180, 26);
            this.indexOfSong.TabIndex = 10;
            // 
            // findByIndex
            // 
            this.findByIndex.Location = new System.Drawing.Point(27, 398);
            this.findByIndex.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.findByIndex.Name = "findByIndex";
            this.findByIndex.Size = new System.Drawing.Size(180, 35);
            this.findByIndex.TabIndex = 9;
            this.findByIndex.Text = "Найти по индексу";
            this.findByIndex.UseVisualStyleBackColor = true;
            this.findByIndex.Click += new System.EventHandler(this.findByIndex_Click);
            // 
            // clearPlaylist
            // 
            this.clearPlaylist.Location = new System.Drawing.Point(27, 303);
            this.clearPlaylist.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clearPlaylist.Name = "clearPlaylist";
            this.clearPlaylist.Size = new System.Drawing.Size(180, 35);
            this.clearPlaylist.TabIndex = 8;
            this.clearPlaylist.Text = "Очистить плейлист";
            this.clearPlaylist.UseVisualStyleBackColor = true;
            this.clearPlaylist.Click += new System.EventHandler(this.clearPlaylist_Click);
            // 
            // nextSong
            // 
            this.nextSong.Location = new System.Drawing.Point(382, 391);
            this.nextSong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nextSong.Name = "nextSong";
            this.nextSong.Size = new System.Drawing.Size(112, 45);
            this.nextSong.TabIndex = 7;
            this.nextSong.Text = ">>";
            this.nextSong.UseVisualStyleBackColor = true;
            this.nextSong.Click += new System.EventHandler(this.nextSong_Click);
            // 
            // previousSong
            // 
            this.previousSong.Location = new System.Drawing.Point(261, 391);
            this.previousSong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.previousSong.Name = "previousSong";
            this.previousSong.Size = new System.Drawing.Size(112, 45);
            this.previousSong.TabIndex = 6;
            this.previousSong.Text = "<<";
            this.previousSong.UseVisualStyleBackColor = true;
            this.previousSong.Click += new System.EventHandler(this.previousSong_Click);
            // 
            // deleteSong
            // 
            this.deleteSong.Location = new System.Drawing.Point(27, 258);
            this.deleteSong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteSong.Name = "deleteSong";
            this.deleteSong.Size = new System.Drawing.Size(180, 35);
            this.deleteSong.TabIndex = 5;
            this.deleteSong.Text = "Удалить";
            this.deleteSong.UseVisualStyleBackColor = true;
            this.deleteSong.Click += new System.EventHandler(this.deleteSong_Click);
            // 
            // addSong
            // 
            this.addSong.Location = new System.Drawing.Point(27, 214);
            this.addSong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addSong.Name = "addSong";
            this.addSong.Size = new System.Drawing.Size(180, 35);
            this.addSong.TabIndex = 4;
            this.addSong.Text = "Добавить";
            this.addSong.UseVisualStyleBackColor = true;
            this.addSong.Click += new System.EventHandler(this.addSong_Click);
            // 
            // pathOfSong
            // 
            this.pathOfSong.Location = new System.Drawing.Point(27, 174);
            this.pathOfSong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pathOfSong.Name = "pathOfSong";
            this.pathOfSong.Size = new System.Drawing.Size(178, 26);
            this.pathOfSong.TabIndex = 3;
            // 
            // songName
            // 
            this.songName.Location = new System.Drawing.Point(27, 114);
            this.songName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.songName.Name = "songName";
            this.songName.Size = new System.Drawing.Size(178, 26);
            this.songName.TabIndex = 2;
            // 
            // authorName
            // 
            this.authorName.Location = new System.Drawing.Point(27, 54);
            this.authorName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.authorName.Name = "authorName";
            this.authorName.Size = new System.Drawing.Size(178, 26);
            this.authorName.TabIndex = 1;
            // 
            // PlaylistShow
            // 
            this.PlaylistShow.FormattingEnabled = true;
            this.PlaylistShow.ItemHeight = 20;
            this.PlaylistShow.Location = new System.Drawing.Point(261, 54);
            this.PlaylistShow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PlaylistShow.Name = "PlaylistShow";
            this.PlaylistShow.Size = new System.Drawing.Size(178, 164);
            this.PlaylistShow.TabIndex = 0;
            // 
            // deleteByIndex
            // 
            this.deleteByIndex.Location = new System.Drawing.Point(27, 443);
            this.deleteByIndex.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteByIndex.Name = "deleteByIndex";
            this.deleteByIndex.Size = new System.Drawing.Size(180, 35);
            this.deleteByIndex.TabIndex = 16;
            this.deleteByIndex.Text = "Удалить по индексу";
            this.deleteByIndex.UseVisualStyleBackColor = true;
            this.deleteByIndex.Click += new System.EventHandler(this.deleteByIndex_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 692);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Магазин";
            ((System.ComponentModel.ISupportInitialize)(this.price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellingCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addProductCount)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.indexOfSong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox productName;
        private System.Windows.Forms.NumericUpDown price;
        private System.Windows.Forms.ListBox ShopList;
        private System.Windows.Forms.Button addProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Money;
        private System.Windows.Forms.TextBox sellingProduct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button sell;
        private System.Windows.Forms.NumericUpDown sellingCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown addProductCount;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.NumericUpDown indexOfSong;
        private System.Windows.Forms.Button findByIndex;
        private System.Windows.Forms.Button clearPlaylist;
        private System.Windows.Forms.Button nextSong;
        private System.Windows.Forms.Button previousSong;
        private System.Windows.Forms.Button deleteSong;
        private System.Windows.Forms.Button addSong;
        private System.Windows.Forms.TextBox pathOfSong;
        private System.Windows.Forms.TextBox songName;
        private System.Windows.Forms.TextBox authorName;
        private System.Windows.Forms.ListBox PlaylistShow;
        private System.Windows.Forms.Button toStart;
        private System.Windows.Forms.Label Track;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button deleteByIndex;
    }
}

