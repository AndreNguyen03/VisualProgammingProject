using System;
using System.Windows.Forms;

namespace StudentsManager.Views
{
    partial class StudentView
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
            this.lblStudents = new System.Windows.Forms.Label();
            this.panelStudents = new System.Windows.Forms.Panel();
            this.tabControlStudent = new System.Windows.Forms.TabControl();
            this.tabPageStudentList = new System.Windows.Forms.TabPage();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.dataGridViewStudentList = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textBoxSearchStudent = new System.Windows.Forms.TextBox();
            this.lblSearchStudent = new System.Windows.Forms.Label();
            this.tabPageStudentDetail = new System.Windows.Forms.TabPage();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.textBoxEnglishScore = new System.Windows.Forms.TextBox();
            this.textBoxLiteratureScore = new System.Windows.Forms.TextBox();
            this.textBoxMathScore = new System.Windows.Forms.TextBox();
            this.textBoxStudentClassName = new System.Windows.Forms.TextBox();
            this.textBoxStudentName = new System.Windows.Forms.TextBox();
            this.textBoxStudentId = new System.Windows.Forms.TextBox();
            this.lblEnglishScore = new System.Windows.Forms.Label();
            this.lblLiteratureScore = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblMathScore = new System.Windows.Forms.Label();
            this.lblStudentClassName = new System.Windows.Forms.Label();
            this.lbStudentId = new System.Windows.Forms.Label();
            this.panelStudents.SuspendLayout();
            this.tabControlStudent.SuspendLayout();
            this.tabPageStudentList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentList)).BeginInit();
            this.tabPageStudentDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStudents
            // 
            this.lblStudents.AutoSize = true;
            this.lblStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudents.Location = new System.Drawing.Point(39, 12);
            this.lblStudents.Name = "lblStudents";
            this.lblStudents.Size = new System.Drawing.Size(97, 25);
            this.lblStudents.TabIndex = 0;
            this.lblStudents.Text = "Students";
            // 
            // panelStudents
            // 
            this.panelStudents.Controls.Add(this.lblStudents);
            this.panelStudents.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStudents.Location = new System.Drawing.Point(0, 0);
            this.panelStudents.Name = "panelStudents";
            this.panelStudents.Size = new System.Drawing.Size(800, 51);
            this.panelStudents.TabIndex = 1;
            // 
            // tabControlStudent
            // 
            this.tabControlStudent.Controls.Add(this.tabPageStudentList);
            this.tabControlStudent.Controls.Add(this.tabPageStudentDetail);
            this.tabControlStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlStudent.Location = new System.Drawing.Point(0, 51);
            this.tabControlStudent.Name = "tabControlStudent";
            this.tabControlStudent.SelectedIndex = 0;
            this.tabControlStudent.Size = new System.Drawing.Size(800, 399);
            this.tabControlStudent.TabIndex = 2;
            // 
            // tabPageStudentList
            // 
            this.tabPageStudentList.Controls.Add(this.btnDelete);
            this.tabPageStudentList.Controls.Add(this.btnEdit);
            this.tabPageStudentList.Controls.Add(this.btnAddNew);
            this.tabPageStudentList.Controls.Add(this.dataGridViewStudentList);
            this.tabPageStudentList.Controls.Add(this.btnSearch);
            this.tabPageStudentList.Controls.Add(this.textBoxSearchStudent);
            this.tabPageStudentList.Controls.Add(this.lblSearchStudent);
            this.tabPageStudentList.Location = new System.Drawing.Point(4, 22);
            this.tabPageStudentList.Name = "tabPageStudentList";
            this.tabPageStudentList.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStudentList.Size = new System.Drawing.Size(792, 373);
            this.tabPageStudentList.TabIndex = 0;
            this.tabPageStudentList.Text = "Student List";
            this.tabPageStudentList.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(695, 153);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(81, 23);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(695, 114);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(81, 23);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNew.BackColor = System.Drawing.Color.White;
            this.btnAddNew.Location = new System.Drawing.Point(695, 75);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(81, 23);
            this.btnAddNew.TabIndex = 11;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = false;
            // 
            // dataGridViewStudentList
            // 
            this.dataGridViewStudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudentList.Location = new System.Drawing.Point(20, 75);
            this.dataGridViewStudentList.Name = "dataGridViewStudentList";
            this.dataGridViewStudentList.Size = new System.Drawing.Size(664, 279);
            this.dataGridViewStudentList.TabIndex = 10;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(603, 37);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(81, 23);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // textBoxSearchStudent
            // 
            this.textBoxSearchStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchStudent.Location = new System.Drawing.Point(20, 38);
            this.textBoxSearchStudent.Name = "textBoxSearchStudent";
            this.textBoxSearchStudent.Size = new System.Drawing.Size(577, 22);
            this.textBoxSearchStudent.TabIndex = 8;
            // 
            // lblSearchStudent
            // 
            this.lblSearchStudent.AutoSize = true;
            this.lblSearchStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchStudent.Location = new System.Drawing.Point(17, 18);
            this.lblSearchStudent.Name = "lblSearchStudent";
            this.lblSearchStudent.Size = new System.Drawing.Size(98, 16);
            this.lblSearchStudent.TabIndex = 7;
            this.lblSearchStudent.Text = "Search Student";
            // 
            // tabPageStudentDetail
            // 
            this.tabPageStudentDetail.Controls.Add(this.btnCancel);
            this.tabPageStudentDetail.Controls.Add(this.btnSave);
            this.tabPageStudentDetail.Controls.Add(this.textBoxEnglishScore);
            this.tabPageStudentDetail.Controls.Add(this.textBoxLiteratureScore);
            this.tabPageStudentDetail.Controls.Add(this.textBoxMathScore);
            this.tabPageStudentDetail.Controls.Add(this.textBoxStudentClassName);
            this.tabPageStudentDetail.Controls.Add(this.textBoxStudentName);
            this.tabPageStudentDetail.Controls.Add(this.textBoxStudentId);
            this.tabPageStudentDetail.Controls.Add(this.lblEnglishScore);
            this.tabPageStudentDetail.Controls.Add(this.lblLiteratureScore);
            this.tabPageStudentDetail.Controls.Add(this.lblStudentName);
            this.tabPageStudentDetail.Controls.Add(this.lblMathScore);
            this.tabPageStudentDetail.Controls.Add(this.lblStudentClassName);
            this.tabPageStudentDetail.Controls.Add(this.lbStudentId);
            this.tabPageStudentDetail.Location = new System.Drawing.Point(4, 22);
            this.tabPageStudentDetail.Name = "tabPageStudentDetail";
            this.tabPageStudentDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStudentDetail.Size = new System.Drawing.Size(792, 373);
            this.tabPageStudentDetail.TabIndex = 1;
            this.tabPageStudentDetail.Text = "Student Detail";
            this.tabPageStudentDetail.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(457, 225);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(97, 40);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.Location = new System.Drawing.Point(457, 151);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 40);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // textBoxEnglishScore
            // 
            this.textBoxEnglishScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEnglishScore.Location = new System.Drawing.Point(186, 310);
            this.textBoxEnglishScore.Name = "textBoxEnglishScore";
            this.textBoxEnglishScore.Size = new System.Drawing.Size(174, 26);
            this.textBoxEnglishScore.TabIndex = 25;
            // 
            // textBoxLiteratureScore
            // 
            this.textBoxLiteratureScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLiteratureScore.Location = new System.Drawing.Point(186, 247);
            this.textBoxLiteratureScore.Name = "textBoxLiteratureScore";
            this.textBoxLiteratureScore.Size = new System.Drawing.Size(174, 26);
            this.textBoxLiteratureScore.TabIndex = 24;
            // 
            // textBoxMathScore
            // 
            this.textBoxMathScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMathScore.Location = new System.Drawing.Point(186, 185);
            this.textBoxMathScore.Name = "textBoxMathScore";
            this.textBoxMathScore.Size = new System.Drawing.Size(174, 26);
            this.textBoxMathScore.TabIndex = 23;
            // 
            // textBoxStudentClassName
            // 
            this.textBoxStudentClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStudentClassName.Location = new System.Drawing.Point(186, 127);
            this.textBoxStudentClassName.Name = "textBoxStudentClassName";
            this.textBoxStudentClassName.Size = new System.Drawing.Size(174, 26);
            this.textBoxStudentClassName.TabIndex = 22;
            // 
            // textBoxStudentName
            // 
            this.textBoxStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStudentName.Location = new System.Drawing.Point(396, 65);
            this.textBoxStudentName.Name = "textBoxStudentName";
            this.textBoxStudentName.Size = new System.Drawing.Size(214, 26);
            this.textBoxStudentName.TabIndex = 21;
            // 
            // textBoxStudentId
            // 
            this.textBoxStudentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStudentId.Location = new System.Drawing.Point(186, 65);
            this.textBoxStudentId.Name = "textBoxStudentId";
            this.textBoxStudentId.Size = new System.Drawing.Size(174, 26);
            this.textBoxStudentId.TabIndex = 20;
            // 
            // lblEnglishScore
            // 
            this.lblEnglishScore.AutoSize = true;
            this.lblEnglishScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnglishScore.Location = new System.Drawing.Point(182, 284);
            this.lblEnglishScore.Name = "lblEnglishScore";
            this.lblEnglishScore.Size = new System.Drawing.Size(112, 20);
            this.lblEnglishScore.TabIndex = 19;
            this.lblEnglishScore.Text = "English score :";
            // 
            // lblLiteratureScore
            // 
            this.lblLiteratureScore.AutoSize = true;
            this.lblLiteratureScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLiteratureScore.Location = new System.Drawing.Point(182, 221);
            this.lblLiteratureScore.Name = "lblLiteratureScore";
            this.lblLiteratureScore.Size = new System.Drawing.Size(128, 20);
            this.lblLiteratureScore.TabIndex = 18;
            this.lblLiteratureScore.Text = "Literature score :";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentName.Location = new System.Drawing.Point(392, 36);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(59, 20);
            this.lblStudentName.TabIndex = 17;
            this.lblStudentName.Text = "Name :";
            // 
            // lblMathScore
            // 
            this.lblMathScore.AutoSize = true;
            this.lblMathScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMathScore.Location = new System.Drawing.Point(182, 159);
            this.lblMathScore.Name = "lblMathScore";
            this.lblMathScore.Size = new System.Drawing.Size(96, 20);
            this.lblMathScore.TabIndex = 16;
            this.lblMathScore.Text = "Math score :";
            // 
            // lblStudentClassName
            // 
            this.lblStudentClassName.AutoSize = true;
            this.lblStudentClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentClassName.Location = new System.Drawing.Point(182, 98);
            this.lblStudentClassName.Name = "lblStudentClassName";
            this.lblStudentClassName.Size = new System.Drawing.Size(100, 20);
            this.lblStudentClassName.TabIndex = 15;
            this.lblStudentClassName.Text = "Class name :";
            // 
            // lbStudentId
            // 
            this.lbStudentId.AutoSize = true;
            this.lbStudentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStudentId.Location = new System.Drawing.Point(182, 36);
            this.lbStudentId.Name = "lbStudentId";
            this.lbStudentId.Size = new System.Drawing.Size(92, 20);
            this.lbStudentId.TabIndex = 14;
            this.lbStudentId.Text = "Student Id :";
            // 
            // StudentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlStudent);
            this.Controls.Add(this.panelStudents);
            this.Name = "StudentView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentView";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StudentView_FormClosed);
            this.panelStudents.ResumeLayout(false);
            this.panelStudents.PerformLayout();
            this.tabControlStudent.ResumeLayout(false);
            this.tabPageStudentList.ResumeLayout(false);
            this.tabPageStudentList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentList)).EndInit();
            this.tabPageStudentDetail.ResumeLayout(false);
            this.tabPageStudentDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblStudents;
        private System.Windows.Forms.Panel panelStudents;
        private System.Windows.Forms.TabControl tabControlStudent;
        private System.Windows.Forms.TabPage tabPageStudentList;
        private System.Windows.Forms.TabPage tabPageStudentDetail;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.DataGridView dataGridViewStudentList;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textBoxSearchStudent;
        private System.Windows.Forms.Label lblSearchStudent;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox textBoxEnglishScore;
        private System.Windows.Forms.TextBox textBoxLiteratureScore;
        private System.Windows.Forms.TextBox textBoxMathScore;
        private System.Windows.Forms.TextBox textBoxStudentClassName;
        private System.Windows.Forms.TextBox textBoxStudentName;
        private System.Windows.Forms.TextBox textBoxStudentId;
        private System.Windows.Forms.Label lblEnglishScore;
        private System.Windows.Forms.Label lblLiteratureScore;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblMathScore;
        private System.Windows.Forms.Label lblStudentClassName;
        private System.Windows.Forms.Label lbStudentId;
    }
}