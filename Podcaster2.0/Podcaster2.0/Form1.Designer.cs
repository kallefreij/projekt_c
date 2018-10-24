﻿namespace Podcaster2._0
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Podcasts = new System.Windows.Forms.TabPage();
            this.BtnRemoveFeed = new System.Windows.Forms.Button();
            this.BtnAddFeed = new System.Windows.Forms.Button();
            this.TbUrl = new System.Windows.Forms.TextBox();
            this.CbCategory = new System.Windows.Forms.ComboBox();
            this.LvFeed = new System.Windows.Forms.ListView();
            this.LvEpisodes = new System.Windows.Forms.ListView();
            this.LblEpisodes = new System.Windows.Forms.Label();
            this.TbDescription = new System.Windows.Forms.TextBox();
            this.Kategorier = new System.Windows.Forms.TabPage();
            this.BtnRemoveCategory = new System.Windows.Forms.Button();
            this.BtnAddCategory = new System.Windows.Forms.Button();
            this.LvCategory = new System.Windows.Forms.ListView();
            this.TbAddCategory = new System.Windows.Forms.TextBox();
            this.CbUpdateInterval = new System.Windows.Forms.ComboBox();
            this.Episodes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Interval = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.Podcasts.SuspendLayout();
            this.Kategorier.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Podcasts);
            this.tabControl1.Controls.Add(this.Kategorier);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(511, 470);
            this.tabControl1.TabIndex = 0;
            // 
            // Podcasts
            // 
            this.Podcasts.BackColor = System.Drawing.Color.Salmon;
            this.Podcasts.Controls.Add(this.CbUpdateInterval);
            this.Podcasts.Controls.Add(this.TbDescription);
            this.Podcasts.Controls.Add(this.LblEpisodes);
            this.Podcasts.Controls.Add(this.LvEpisodes);
            this.Podcasts.Controls.Add(this.BtnRemoveFeed);
            this.Podcasts.Controls.Add(this.BtnAddFeed);
            this.Podcasts.Controls.Add(this.TbUrl);
            this.Podcasts.Controls.Add(this.CbCategory);
            this.Podcasts.Controls.Add(this.LvFeed);
            this.Podcasts.Location = new System.Drawing.Point(4, 25);
            this.Podcasts.Name = "Podcasts";
            this.Podcasts.Padding = new System.Windows.Forms.Padding(3);
            this.Podcasts.Size = new System.Drawing.Size(503, 441);
            this.Podcasts.TabIndex = 0;
            this.Podcasts.Text = "Podcasts";
            // 
            // BtnRemoveFeed
            // 
            this.BtnRemoveFeed.Location = new System.Drawing.Point(220, 186);
            this.BtnRemoveFeed.Name = "BtnRemoveFeed";
            this.BtnRemoveFeed.Size = new System.Drawing.Size(90, 23);
            this.BtnRemoveFeed.TabIndex = 4;
            this.BtnRemoveFeed.Text = "Ta bort";
            this.BtnRemoveFeed.UseVisualStyleBackColor = true;
            // 
            // BtnAddFeed
            // 
            this.BtnAddFeed.Location = new System.Drawing.Point(124, 186);
            this.BtnAddFeed.Name = "BtnAddFeed";
            this.BtnAddFeed.Size = new System.Drawing.Size(90, 23);
            this.BtnAddFeed.TabIndex = 3;
            this.BtnAddFeed.Text = "Lägg till";
            this.BtnAddFeed.UseVisualStyleBackColor = true;
            // 
            // TbUrl
            // 
            this.TbUrl.Location = new System.Drawing.Point(6, 158);
            this.TbUrl.Name = "TbUrl";
            this.TbUrl.Size = new System.Drawing.Size(307, 22);
            this.TbUrl.TabIndex = 2;
            this.TbUrl.Text = "http://";
            this.TbUrl.Enter += new System.EventHandler(this.TbUrl_Enter);
            // 
            // CbCategory
            // 
            this.CbCategory.FormattingEnabled = true;
            this.CbCategory.Location = new System.Drawing.Point(316, 158);
            this.CbCategory.Name = "CbCategory";
            this.CbCategory.Size = new System.Drawing.Size(181, 24);
            this.CbCategory.TabIndex = 1;
            // 
            // LvFeed
            // 
            this.LvFeed.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Episodes,
            this.Title,
            this.Interval,
            this.Category});
            this.LvFeed.Location = new System.Drawing.Point(6, 6);
            this.LvFeed.Name = "LvFeed";
            this.LvFeed.Size = new System.Drawing.Size(491, 146);
            this.LvFeed.TabIndex = 0;
            this.LvFeed.UseCompatibleStateImageBehavior = false;
            this.LvFeed.View = System.Windows.Forms.View.Details;
            // 
            // LvEpisodes
            // 
            this.LvEpisodes.Location = new System.Drawing.Point(6, 218);
            this.LvEpisodes.Name = "LvEpisodes";
            this.LvEpisodes.Size = new System.Drawing.Size(304, 217);
            this.LvEpisodes.TabIndex = 5;
            this.LvEpisodes.UseCompatibleStateImageBehavior = false;
            // 
            // LblEpisodes
            // 
            this.LblEpisodes.AutoSize = true;
            this.LblEpisodes.Location = new System.Drawing.Point(4, 195);
            this.LblEpisodes.Name = "LblEpisodes";
            this.LblEpisodes.Size = new System.Drawing.Size(46, 17);
            this.LblEpisodes.TabIndex = 6;
            this.LblEpisodes.Text = "label1";
            // 
            // TbDescription
            // 
            this.TbDescription.Location = new System.Drawing.Point(316, 218);
            this.TbDescription.Multiline = true;
            this.TbDescription.Name = "TbDescription";
            this.TbDescription.Size = new System.Drawing.Size(181, 217);
            this.TbDescription.TabIndex = 7;
            // 
            // Kategorier
            // 
            this.Kategorier.BackColor = System.Drawing.Color.PeachPuff;
            this.Kategorier.Controls.Add(this.TbAddCategory);
            this.Kategorier.Controls.Add(this.BtnRemoveCategory);
            this.Kategorier.Controls.Add(this.BtnAddCategory);
            this.Kategorier.Controls.Add(this.LvCategory);
            this.Kategorier.Location = new System.Drawing.Point(4, 25);
            this.Kategorier.Name = "Kategorier";
            this.Kategorier.Padding = new System.Windows.Forms.Padding(3);
            this.Kategorier.Size = new System.Drawing.Size(503, 441);
            this.Kategorier.TabIndex = 1;
            this.Kategorier.Text = "Kategorier";
            // 
            // BtnRemoveCategory
            // 
            this.BtnRemoveCategory.Location = new System.Drawing.Point(405, 201);
            this.BtnRemoveCategory.Name = "BtnRemoveCategory";
            this.BtnRemoveCategory.Size = new System.Drawing.Size(90, 23);
            this.BtnRemoveCategory.TabIndex = 11;
            this.BtnRemoveCategory.Text = "Ta bort";
            this.BtnRemoveCategory.UseVisualStyleBackColor = true;
            // 
            // BtnAddCategory
            // 
            this.BtnAddCategory.Location = new System.Drawing.Point(306, 201);
            this.BtnAddCategory.Name = "BtnAddCategory";
            this.BtnAddCategory.Size = new System.Drawing.Size(90, 23);
            this.BtnAddCategory.TabIndex = 10;
            this.BtnAddCategory.Text = "Lägg till";
            this.BtnAddCategory.UseVisualStyleBackColor = true;
            // 
            // LvCategory
            // 
            this.LvCategory.Location = new System.Drawing.Point(6, 6);
            this.LvCategory.Name = "LvCategory";
            this.LvCategory.Size = new System.Drawing.Size(489, 189);
            this.LvCategory.TabIndex = 7;
            this.LvCategory.UseCompatibleStateImageBehavior = false;
            // 
            // TbAddCategory
            // 
            this.TbAddCategory.Location = new System.Drawing.Point(8, 201);
            this.TbAddCategory.Name = "TbAddCategory";
            this.TbAddCategory.Size = new System.Drawing.Size(136, 22);
            this.TbAddCategory.TabIndex = 12;
            // 
            // CbUpdateInterval
            // 
            this.CbUpdateInterval.FormattingEnabled = true;
            this.CbUpdateInterval.Location = new System.Drawing.Point(316, 188);
            this.CbUpdateInterval.Name = "CbUpdateInterval";
            this.CbUpdateInterval.Size = new System.Drawing.Size(181, 24);
            this.CbUpdateInterval.TabIndex = 8;
            // 
            // Episodes
            // 
            this.Episodes.Text = "Avsnitt";
            this.Episodes.Width = 100;
            // 
            // Title
            // 
            this.Title.Text = "Titel";
            this.Title.Width = 175;
            // 
            // Interval
            // 
            this.Interval.Text = "Frekvens";
            this.Interval.Width = 149;
            // 
            // Category
            // 
            this.Category.Text = "Kategori";
            this.Category.Width = 103;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 470);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.Podcasts.ResumeLayout(false);
            this.Podcasts.PerformLayout();
            this.Kategorier.ResumeLayout(false);
            this.Kategorier.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Podcasts;
        private System.Windows.Forms.TabPage Kategorier;
        private System.Windows.Forms.Button BtnRemoveFeed;
        private System.Windows.Forms.Button BtnAddFeed;
        private System.Windows.Forms.TextBox TbUrl;
        private System.Windows.Forms.ComboBox CbCategory;
        private System.Windows.Forms.ListView LvFeed;
        private System.Windows.Forms.TextBox TbDescription;
        private System.Windows.Forms.Label LblEpisodes;
        private System.Windows.Forms.ListView LvEpisodes;
        private System.Windows.Forms.ComboBox CbUpdateInterval;
        private System.Windows.Forms.TextBox TbAddCategory;
        private System.Windows.Forms.Button BtnRemoveCategory;
        private System.Windows.Forms.Button BtnAddCategory;
        private System.Windows.Forms.ListView LvCategory;
        private System.Windows.Forms.ColumnHeader Episodes;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Interval;
        private System.Windows.Forms.ColumnHeader Category;
    }
}

