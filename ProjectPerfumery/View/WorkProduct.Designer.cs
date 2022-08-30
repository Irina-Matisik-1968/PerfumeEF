
namespace ProjectPerfumery
{
    partial class WorkProduct
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkProduct));
            this.tableLayoutPanelTop = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.tableLayoutPanelBottom = new System.Windows.Forms.TableLayoutPanel();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonFixedDB = new System.Windows.Forms.Button();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.labelId = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxiD = new System.Windows.Forms.TextBox();
            this.textBoxDisc = new System.Windows.Forms.TextBox();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.textBoxDiscont = new System.Windows.Forms.TextBox();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.buttonSelectPhoto = new System.Windows.Forms.Button();
            this.comboBoxCat = new System.Windows.Forms.ComboBox();
            this.openFileDialogPhoto = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanelBottom.SuspendLayout();
            this.tableLayoutPanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelTop
            // 
            this.tableLayoutPanelTop.BackColor = System.Drawing.Color.NavajoWhite;
            this.tableLayoutPanelTop.ColumnCount = 3;
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.751773F));
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.37589F));
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.04964F));
            this.tableLayoutPanelTop.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanelTop.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanelTop.Controls.Add(this.buttonBack, 2, 0);
            this.tableLayoutPanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelTop.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelTop.Name = "tableLayoutPanelTop";
            this.tableLayoutPanelTop.RowCount = 1;
            this.tableLayoutPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanelTop.Size = new System.Drawing.Size(658, 59);
            this.tableLayoutPanelTop.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjectPerfumery.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(67, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(436, 59);
            this.label1.TabIndex = 1;
            this.label1.Text = "Работа с одним продуктом";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonBack
            // 
            this.buttonBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonBack.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(516, 10);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(10);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(132, 39);
            this.buttonBack.TabIndex = 2;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // tableLayoutPanelBottom
            // 
            this.tableLayoutPanelBottom.BackColor = System.Drawing.Color.MistyRose;
            this.tableLayoutPanelBottom.ColumnCount = 2;
            this.tableLayoutPanelBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.87234F));
            this.tableLayoutPanelBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.12766F));
            this.tableLayoutPanelBottom.Controls.Add(this.buttonDelete, 0, 0);
            this.tableLayoutPanelBottom.Controls.Add(this.buttonFixedDB, 0, 0);
            this.tableLayoutPanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanelBottom.Location = new System.Drawing.Point(0, 393);
            this.tableLayoutPanelBottom.Name = "tableLayoutPanelBottom";
            this.tableLayoutPanelBottom.RowCount = 1;
            this.tableLayoutPanelBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelBottom.Size = new System.Drawing.Size(658, 63);
            this.tableLayoutPanelBottom.TabIndex = 3;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDelete.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.Location = new System.Drawing.Point(345, 10);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(30, 10, 30, 10);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(283, 43);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Удалить товар";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonFixedDB
            // 
            this.buttonFixedDB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonFixedDB.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFixedDB.Location = new System.Drawing.Point(30, 10);
            this.buttonFixedDB.Margin = new System.Windows.Forms.Padding(30, 10, 30, 10);
            this.buttonFixedDB.Name = "buttonFixedDB";
            this.buttonFixedDB.Size = new System.Drawing.Size(255, 43);
            this.buttonFixedDB.TabIndex = 3;
            this.buttonFixedDB.Text = "Фиксировать изменения в БД";
            this.buttonFixedDB.UseVisualStyleBackColor = true;
            this.buttonFixedDB.Click += new System.EventHandler(this.buttonFixedDB_Click);
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 3;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.69301F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.37082F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.08815F));
            this.tableLayoutPanelMain.Controls.Add(this.labelId, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanelMain.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanelMain.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanelMain.Controls.Add(this.label7, 0, 5);
            this.tableLayoutPanelMain.Controls.Add(this.textBoxiD, 1, 0);
            this.tableLayoutPanelMain.Controls.Add(this.textBoxDisc, 1, 1);
            this.tableLayoutPanelMain.Controls.Add(this.textBoxCost, 1, 3);
            this.tableLayoutPanelMain.Controls.Add(this.textBoxDiscont, 1, 4);
            this.tableLayoutPanelMain.Controls.Add(this.textBoxCount, 1, 5);
            this.tableLayoutPanelMain.Controls.Add(this.pictureBoxPhoto, 2, 1);
            this.tableLayoutPanelMain.Controls.Add(this.buttonSelectPhoto, 2, 4);
            this.tableLayoutPanelMain.Controls.Add(this.comboBoxCat, 1, 2);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 59);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 6;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.57485F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.83832F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.77246F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.47305F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.67066F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.16767F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(658, 334);
            this.tableLayoutPanelMain.TabIndex = 4;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.BackColor = System.Drawing.SystemColors.Control;
            this.labelId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelId.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelId.Location = new System.Drawing.Point(3, 0);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(116, 41);
            this.labelId.TabIndex = 0;
            this.labelId.Text = "Номер";
            this.labelId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 101);
            this.label3.TabIndex = 1;
            this.label3.Text = "Описание";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 45);
            this.label4.TabIndex = 2;
            this.label4.Text = "Категория";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(3, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 44);
            this.label5.TabIndex = 3;
            this.label5.Text = "Цена";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(3, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 48);
            this.label6.TabIndex = 4;
            this.label6.Text = "Скидка";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(3, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 55);
            this.label7.TabIndex = 5;
            this.label7.Text = "Количество";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxiD
            // 
            this.textBoxiD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxiD.Location = new System.Drawing.Point(132, 10);
            this.textBoxiD.Margin = new System.Windows.Forms.Padding(10);
            this.textBoxiD.Name = "textBoxiD";
            this.textBoxiD.Size = new System.Drawing.Size(192, 30);
            this.textBoxiD.TabIndex = 6;
            // 
            // textBoxDisc
            // 
            this.textBoxDisc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDisc.Location = new System.Drawing.Point(132, 51);
            this.textBoxDisc.Margin = new System.Windows.Forms.Padding(10);
            this.textBoxDisc.Multiline = true;
            this.textBoxDisc.Name = "textBoxDisc";
            this.textBoxDisc.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxDisc.Size = new System.Drawing.Size(192, 81);
            this.textBoxDisc.TabIndex = 7;
            // 
            // textBoxCost
            // 
            this.textBoxCost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCost.Location = new System.Drawing.Point(132, 197);
            this.textBoxCost.Margin = new System.Windows.Forms.Padding(10);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(192, 30);
            this.textBoxCost.TabIndex = 8;
            // 
            // textBoxDiscont
            // 
            this.textBoxDiscont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDiscont.Location = new System.Drawing.Point(132, 241);
            this.textBoxDiscont.Margin = new System.Windows.Forms.Padding(10);
            this.textBoxDiscont.Name = "textBoxDiscont";
            this.textBoxDiscont.Size = new System.Drawing.Size(192, 30);
            this.textBoxDiscont.TabIndex = 9;
            // 
            // textBoxCount
            // 
            this.textBoxCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCount.Location = new System.Drawing.Point(132, 289);
            this.textBoxCount.Margin = new System.Windows.Forms.Padding(10);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(192, 30);
            this.textBoxCount.TabIndex = 10;
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxPhoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxPhoto.Location = new System.Drawing.Point(344, 51);
            this.pictureBoxPhoto.Margin = new System.Windows.Forms.Padding(10);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.tableLayoutPanelMain.SetRowSpan(this.pictureBoxPhoto, 3);
            this.pictureBoxPhoto.Size = new System.Drawing.Size(304, 170);
            this.pictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPhoto.TabIndex = 12;
            this.pictureBoxPhoto.TabStop = false;
            // 
            // buttonSelectPhoto
            // 
            this.buttonSelectPhoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSelectPhoto.Location = new System.Drawing.Point(364, 241);
            this.buttonSelectPhoto.Margin = new System.Windows.Forms.Padding(30, 10, 30, 10);
            this.buttonSelectPhoto.Name = "buttonSelectPhoto";
            this.buttonSelectPhoto.Size = new System.Drawing.Size(264, 28);
            this.buttonSelectPhoto.TabIndex = 13;
            this.buttonSelectPhoto.Text = "Выбрать фото";
            this.buttonSelectPhoto.UseVisualStyleBackColor = true;
            this.buttonSelectPhoto.Click += new System.EventHandler(this.buttonSelectPhoto_Click);
            // 
            // comboBoxCat
            // 
            this.comboBoxCat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxCat.FormattingEnabled = true;
            this.comboBoxCat.Location = new System.Drawing.Point(132, 152);
            this.comboBoxCat.Margin = new System.Windows.Forms.Padding(10);
            this.comboBoxCat.Name = "comboBoxCat";
            this.comboBoxCat.Size = new System.Drawing.Size(192, 31);
            this.comboBoxCat.TabIndex = 14;
            // 
            // openFileDialogPhoto
            // 
            this.openFileDialogPhoto.FileName = "openFileDialog1";
            // 
            // WorkProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 456);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Controls.Add(this.tableLayoutPanelBottom);
            this.Controls.Add(this.tableLayoutPanelTop);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(674, 479);
            this.Name = "WorkProduct";
            this.Text = "Обработка одного продукта";
            this.Shown += new System.EventHandler(this.WorkProduct_Shown);
            this.tableLayoutPanelTop.ResumeLayout(false);
            this.tableLayoutPanelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanelBottom.ResumeLayout(false);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBottom;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonFixedDB;
        private System.Windows.Forms.TextBox textBoxiD;
        private System.Windows.Forms.TextBox textBoxDisc;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.TextBox textBoxDiscont;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.PictureBox pictureBoxPhoto;
        private System.Windows.Forms.Button buttonSelectPhoto;
        private System.Windows.Forms.ComboBox comboBoxCat;
        private System.Windows.Forms.OpenFileDialog openFileDialogPhoto;
        private System.Windows.Forms.Button buttonDelete;
    }
}

