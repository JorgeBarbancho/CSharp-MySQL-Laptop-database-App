
using System;
using System.Drawing;

namespace EAC2Ex3
{
    partial class laptopViewer
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.viewer = new System.Windows.Forms.GroupBox();
            this.favList = new System.Windows.Forms.DataGridView();
            this.favListButton = new System.Windows.Forms.Button();
            this.starBox = new System.Windows.Forms.PictureBox();
            this.favButton = new System.Windows.Forms.Button();
            this.lastButton = new System.Windows.Forms.Button();
            this.firstButton = new System.Windows.Forms.Button();
            this.charsButton = new System.Windows.Forms.CheckBox();
            this.imageButton = new System.Windows.Forms.CheckBox();
            this.nextButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.charsBox = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.Label();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.favList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.starBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // viewer
            // 
            this.viewer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(231)))), ((int)(((byte)(241)))));
            this.viewer.Controls.Add(this.favList);
            this.viewer.Controls.Add(this.favListButton);
            this.viewer.Controls.Add(this.starBox);
            this.viewer.Controls.Add(this.favButton);
            this.viewer.Controls.Add(this.lastButton);
            this.viewer.Controls.Add(this.firstButton);
            this.viewer.Controls.Add(this.charsButton);
            this.viewer.Controls.Add(this.imageButton);
            this.viewer.Controls.Add(this.nextButton);
            this.viewer.Controls.Add(this.backButton);
            this.viewer.Controls.Add(this.imageBox);
            this.viewer.Controls.Add(this.priceLabel);
            this.viewer.Controls.Add(this.nameLabel);
            this.viewer.Controls.Add(this.charsBox);
            this.viewer.Location = new System.Drawing.Point(12, 50);
            this.viewer.Name = "viewer";
            this.viewer.Size = new System.Drawing.Size(862, 623);
            this.viewer.TabIndex = 1;
            this.viewer.TabStop = false;
            // 
            // favList
            // 
            this.favList.AllowUserToOrderColumns = true;
            this.favList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(89)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Miriam Libre", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.favList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.favList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.favList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.price});
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Miriam Libre", 15F);
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.favList.DefaultCellStyle = dataGridViewCellStyle16;
            this.favList.Location = new System.Drawing.Point(12, 80);
            this.favList.Name = "favList";
            this.favList.RowHeadersVisible = false;
            this.favList.Size = new System.Drawing.Size(531, 536);
            this.favList.TabIndex = 13;
            // 
            // favListButton
            // 
            this.favListButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(89)))), ((int)(((byte)(107)))));
            this.favListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.favListButton.Font = new System.Drawing.Font("Miriam Libre", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.favListButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(220)))), ((int)(((byte)(235)))));
            this.favListButton.Location = new System.Drawing.Point(595, 409);
            this.favListButton.Name = "favListButton";
            this.favListButton.Size = new System.Drawing.Size(221, 27);
            this.favListButton.TabIndex = 12;
            this.favListButton.Text = "ver favoritos";
            this.favListButton.UseVisualStyleBackColor = false;
            this.favListButton.Click += new System.EventHandler(this.favListButton_Click);
            // 
            // starBox
            // 
            this.starBox.Image = global::EAC2Ex3.Properties.Resources.goldStar;
            this.starBox.Location = new System.Drawing.Point(539, 18);
            this.starBox.Name = "starBox";
            this.starBox.Size = new System.Drawing.Size(50, 48);
            this.starBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.starBox.TabIndex = 3;
            this.starBox.TabStop = false;
            this.starBox.Click += new System.EventHandler(this.starButton_Click);
            // 
            // favButton
            // 
            this.favButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(89)))), ((int)(((byte)(107)))));
            this.favButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.favButton.Font = new System.Drawing.Font("Miriam Libre", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.favButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(220)))), ((int)(((byte)(235)))));
            this.favButton.Location = new System.Drawing.Point(595, 333);
            this.favButton.Name = "favButton";
            this.favButton.Size = new System.Drawing.Size(221, 27);
            this.favButton.TabIndex = 10;
            this.favButton.Text = "añadir a favoritos";
            this.favButton.UseVisualStyleBackColor = false;
            this.favButton.Click += new System.EventHandler(this.FavButton_Click);
            // 
            // lastButton
            // 
            this.lastButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(89)))), ((int)(((byte)(107)))));
            this.lastButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lastButton.Font = new System.Drawing.Font("Miriam Libre", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(220)))), ((int)(((byte)(235)))));
            this.lastButton.Location = new System.Drawing.Point(775, 159);
            this.lastButton.Name = "lastButton";
            this.lastButton.Size = new System.Drawing.Size(63, 53);
            this.lastButton.TabIndex = 9;
            this.lastButton.Text = ">>";
            this.lastButton.UseVisualStyleBackColor = false;
            this.lastButton.Click += new System.EventHandler(this.LastButton_Click);
            // 
            // firstButton
            // 
            this.firstButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(89)))), ((int)(((byte)(107)))));
            this.firstButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.firstButton.Font = new System.Drawing.Font("Miriam Libre", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(220)))), ((int)(((byte)(235)))));
            this.firstButton.Location = new System.Drawing.Point(567, 159);
            this.firstButton.Name = "firstButton";
            this.firstButton.Size = new System.Drawing.Size(63, 53);
            this.firstButton.TabIndex = 8;
            this.firstButton.Text = "<<";
            this.firstButton.UseVisualStyleBackColor = false;
            this.firstButton.Click += new System.EventHandler(this.FirstButton_Click);
            // 
            // charsButton
            // 
            this.charsButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.charsButton.AutoSize = true;
            this.charsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(89)))), ((int)(((byte)(107)))));
            this.charsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.charsButton.Font = new System.Drawing.Font("Miriam Libre", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.charsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(220)))), ((int)(((byte)(235)))));
            this.charsButton.Location = new System.Drawing.Point(706, 262);
            this.charsButton.Name = "charsButton";
            this.charsButton.Size = new System.Drawing.Size(110, 27);
            this.charsButton.TabIndex = 7;
            this.charsButton.Text = "características";
            this.charsButton.UseVisualStyleBackColor = false;
            this.charsButton.Click += new System.EventHandler(this.CharsButton_Click);
            // 
            // imageButton
            // 
            this.imageButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.imageButton.AutoSize = true;
            this.imageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(89)))), ((int)(((byte)(107)))));
            this.imageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.imageButton.Font = new System.Drawing.Font("Miriam Libre", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.imageButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(220)))), ((int)(((byte)(235)))));
            this.imageButton.Location = new System.Drawing.Point(595, 262);
            this.imageButton.Name = "imageButton";
            this.imageButton.Size = new System.Drawing.Size(105, 27);
            this.imageButton.TabIndex = 6;
            this.imageButton.Text = "     imagen     ";
            this.imageButton.UseVisualStyleBackColor = false;
            this.imageButton.Click += new System.EventHandler(this.ImageButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(89)))), ((int)(((byte)(107)))));
            this.nextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextButton.Font = new System.Drawing.Font("Miriam Libre", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(220)))), ((int)(((byte)(235)))));
            this.nextButton.Location = new System.Drawing.Point(705, 159);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(65, 53);
            this.nextButton.TabIndex = 5;
            this.nextButton.Text = ">";
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(89)))), ((int)(((byte)(107)))));
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Miriam Libre", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(220)))), ((int)(((byte)(235)))));
            this.backButton.Location = new System.Drawing.Point(635, 159);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(65, 53);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "<";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // imageBox
            // 
            this.imageBox.Location = new System.Drawing.Point(17, 80);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(526, 537);
            this.imageBox.TabIndex = 3;
            this.imageBox.TabStop = false;
            // 
            // priceLabel
            // 
            this.priceLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.priceLabel.Font = new System.Drawing.Font("Miriam Libre", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(89)))), ((int)(((byte)(107)))));
            this.priceLabel.Location = new System.Drawing.Point(595, 8);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.priceLabel.Size = new System.Drawing.Size(261, 63);
            this.priceLabel.TabIndex = 2;
            this.priceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Miriam Libre", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(89)))), ((int)(((byte)(107)))));
            this.nameLabel.Location = new System.Drawing.Point(8, 18);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(0, 49);
            this.nameLabel.TabIndex = 1;
            // 
            // charsBox
            // 
            this.charsBox.Font = new System.Drawing.Font("Miriam Libre", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charsBox.Location = new System.Drawing.Point(17, 80);
            this.charsBox.Multiline = true;
            this.charsBox.Name = "charsBox";
            this.charsBox.ReadOnly = true;
            this.charsBox.Size = new System.Drawing.Size(526, 537);
            this.charsBox.TabIndex = 0;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Miriam Libre", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(220)))), ((int)(((byte)(235)))));
            this.title.Location = new System.Drawing.Point(18, 15);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(210, 32);
            this.title.TabIndex = 2;
            this.title.Text = "laptop database";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // name
            // 
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Miriam Libre", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.DefaultCellStyle = dataGridViewCellStyle14;
            this.name.FillWeight = 194.9239F;
            this.name.HeaderText = "NOMBRE";
            this.name.Name = "name";
            this.name.Width = 398;
            // 
            // price
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Miriam Libre", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.DefaultCellStyle = dataGridViewCellStyle15;
            this.price.FillWeight = 5.076141F;
            this.price.HeaderText = "PRECIO";
            this.price.Name = "price";
            this.price.Width = 130;
            // 
            // laptopViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(89)))), ((int)(((byte)(107)))));
            this.ClientSize = new System.Drawing.Size(886, 685);
            this.Controls.Add(this.title);
            this.Controls.Add(this.viewer);
            this.Name = "laptopViewer";
            this.viewer.ResumeLayout(false);
            this.viewer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.favList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.starBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }        

        #endregion
        private System.Windows.Forms.GroupBox viewer;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox charsBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.PictureBox imageBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.CheckBox charsButton;
        private System.Windows.Forms.CheckBox imageButton;
        private System.Windows.Forms.Button lastButton;
        private System.Windows.Forms.Button firstButton;
        private System.Windows.Forms.Button favButton;
        private System.Windows.Forms.PictureBox starBox;
        private System.Windows.Forms.Button favListButton;
        private System.Windows.Forms.DataGridView favList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
    }
}

