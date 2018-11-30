namespace ICA11_RegexDictionary
{
    partial class ICA11_RegexDictionary
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
            this.LV_Words = new System.Windows.Forms.ListView();
            this.Word = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.B_LoadFile = new System.Windows.Forms.Button();
            this.B_SortCount = new System.Windows.Forms.Button();
            this.B_RemoveWords = new System.Windows.Forms.Button();
            this.B_SortLength = new System.Windows.Forms.Button();
            this.OFD_WordFile = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // LV_Words
            // 
            this.LV_Words.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Word,
            this.Count});
            this.LV_Words.GridLines = true;
            this.LV_Words.Location = new System.Drawing.Point(13, 13);
            this.LV_Words.Name = "LV_Words";
            this.LV_Words.Size = new System.Drawing.Size(429, 302);
            this.LV_Words.TabIndex = 0;
            this.LV_Words.UseCompatibleStateImageBehavior = false;
            this.LV_Words.View = System.Windows.Forms.View.Details;
            // 
            // Word
            // 
            this.Word.Text = "Word";
            this.Word.Width = 326;
            // 
            // Count
            // 
            this.Count.Text = "Count";
            this.Count.Width = 100;
            // 
            // B_LoadFile
            // 
            this.B_LoadFile.Location = new System.Drawing.Point(13, 322);
            this.B_LoadFile.Name = "B_LoadFile";
            this.B_LoadFile.Size = new System.Drawing.Size(139, 23);
            this.B_LoadFile.TabIndex = 1;
            this.B_LoadFile.Text = "Load Word File...";
            this.B_LoadFile.UseVisualStyleBackColor = true;
            this.B_LoadFile.Click += new System.EventHandler(this.B_LoadFile_Click);
            // 
            // B_SortCount
            // 
            this.B_SortCount.Location = new System.Drawing.Point(158, 321);
            this.B_SortCount.Name = "B_SortCount";
            this.B_SortCount.Size = new System.Drawing.Size(139, 23);
            this.B_SortCount.TabIndex = 2;
            this.B_SortCount.Text = "Sort By Count";
            this.B_SortCount.UseVisualStyleBackColor = true;
            this.B_SortCount.Click += new System.EventHandler(this.B_SortCount_Click);
            // 
            // B_RemoveWords
            // 
            this.B_RemoveWords.Location = new System.Drawing.Point(87, 350);
            this.B_RemoveWords.Name = "B_RemoveWords";
            this.B_RemoveWords.Size = new System.Drawing.Size(287, 23);
            this.B_RemoveWords.TabIndex = 3;
            this.B_RemoveWords.Text = "Remove Words w/ Numbers";
            this.B_RemoveWords.UseVisualStyleBackColor = true;
            this.B_RemoveWords.Click += new System.EventHandler(this.B_RemoveWords_Click);
            // 
            // B_SortLength
            // 
            this.B_SortLength.Location = new System.Drawing.Point(303, 322);
            this.B_SortLength.Name = "B_SortLength";
            this.B_SortLength.Size = new System.Drawing.Size(139, 23);
            this.B_SortLength.TabIndex = 4;
            this.B_SortLength.Text = "Sort by Word Length";
            this.B_SortLength.UseVisualStyleBackColor = true;
            this.B_SortLength.Click += new System.EventHandler(this.B_SortLength_Click);
            // 
            // OFD_WordFile
            // 
            this.OFD_WordFile.FileName = "openFileDialog1";
            // 
            // ICA11_RegexDictionary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 385);
            this.Controls.Add(this.B_SortLength);
            this.Controls.Add(this.B_RemoveWords);
            this.Controls.Add(this.B_SortCount);
            this.Controls.Add(this.B_LoadFile);
            this.Controls.Add(this.LV_Words);
            this.Name = "ICA11_RegexDictionary";
            this.Text = "Regex Munchy String";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView LV_Words;
        private System.Windows.Forms.Button B_LoadFile;
        private System.Windows.Forms.Button B_SortCount;
        private System.Windows.Forms.Button B_RemoveWords;
        private System.Windows.Forms.Button B_SortLength;
        private System.Windows.Forms.ColumnHeader Word;
        private System.Windows.Forms.ColumnHeader Count;
        private System.Windows.Forms.OpenFileDialog OFD_WordFile;
    }
}

