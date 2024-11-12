﻿namespace SegundoParcialElipses.Windows
{
    partial class frmElipses
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripButton4 = new ToolStripDropDownButton();
            bordeToolStripMenuItem = new ToolStripMenuItem();
            tsCboBordes = new ToolStripComboBox();
            toolStripButton5 = new ToolStripDropDownButton();
            área09ToolStripMenuItem = new ToolStripMenuItem();
            área90ToolStripMenuItem = new ToolStripMenuItem();
            toolStripButton6 = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripButton7 = new ToolStripButton();
            panelCantidad = new Panel();
            txtCantidad = new TextBox();
            label1 = new Label();
            dgvDatos = new DataGridView();
            colMayor = new DataGridViewTextBoxColumn();
            colMenor = new DataGridViewTextBoxColumn();
            colBorde = new DataGridViewTextBoxColumn();
            colColor = new DataGridViewTextBoxColumn();
            colPerimetro = new DataGridViewTextBoxColumn();
            colArea = new DataGridViewTextBoxColumn();
            toolStrip1.SuspendLayout();
            panelCantidad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripButton3, toolStripSeparator1, toolStripButton4, toolStripButton5, toolStripButton6, toolStripSeparator2, toolStripButton7 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(874, 75);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.Image = Properties.Resources.add_file_48px;
            toolStripButton1.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(56, 72);
            toolStripButton1.Text = "Nuevo";
            toolStripButton1.TextImageRelation = TextImageRelation.ImageAboveText;
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.Image = Properties.Resources.delete_file_48px;
            toolStripButton2.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(54, 72);
            toolStripButton2.Text = "Borrar";
            toolStripButton2.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripButton3
            // 
            toolStripButton3.Image = Properties.Resources.edit_file_48px;
            toolStripButton3.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(52, 72);
            toolStripButton3.Text = "Editar";
            toolStripButton3.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 75);
            // 
            // toolStripButton4
            // 
            toolStripButton4.DropDownItems.AddRange(new ToolStripItem[] { bordeToolStripMenuItem });
            toolStripButton4.Image = Properties.Resources.filled_filter_48px;
            toolStripButton4.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(62, 72);
            toolStripButton4.Text = "Filtar";
            toolStripButton4.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // bordeToolStripMenuItem
            // 
            bordeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tsCboBordes });
            bordeToolStripMenuItem.Image = Properties.Resources.filled_filter_48px;
            bordeToolStripMenuItem.Name = "bordeToolStripMenuItem";
            bordeToolStripMenuItem.Size = new Size(132, 26);
            bordeToolStripMenuItem.Text = "Borde";
            // 
            // tsCboBordes
            // 
            tsCboBordes.Name = "tsCboBordes";
            tsCboBordes.Size = new Size(121, 28);
            // 
            // toolStripButton5
            // 
            toolStripButton5.DropDownItems.AddRange(new ToolStripItem[] { área09ToolStripMenuItem, área90ToolStripMenuItem });
            toolStripButton5.Image = Properties.Resources.sorting_answers_48px;
            toolStripButton5.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton5.ImageTransparentColor = Color.Magenta;
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new Size(77, 72);
            toolStripButton5.Text = "Ordenar";
            toolStripButton5.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // área09ToolStripMenuItem
            // 
            área09ToolStripMenuItem.Image = Properties.Resources.numerical_sorting_12_48px;
            área09ToolStripMenuItem.Name = "área09ToolStripMenuItem";
            área09ToolStripMenuItem.Size = new Size(159, 26);
            área09ToolStripMenuItem.Text = "Área (0-9)";
            // 
            // área90ToolStripMenuItem
            // 
            área90ToolStripMenuItem.Image = Properties.Resources.numerical_sorting_21_48px;
            área90ToolStripMenuItem.Name = "área90ToolStripMenuItem";
            área90ToolStripMenuItem.Size = new Size(159, 26);
            área90ToolStripMenuItem.Text = "Área (9-0)";
            // 
            // toolStripButton6
            // 
            toolStripButton6.Image = Properties.Resources.restart_48px;
            toolStripButton6.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton6.ImageTransparentColor = Color.Magenta;
            toolStripButton6.Name = "toolStripButton6";
            toolStripButton6.Size = new Size(79, 72);
            toolStripButton6.Text = "Actualizar";
            toolStripButton6.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 75);
            // 
            // toolStripButton7
            // 
            toolStripButton7.Image = Properties.Resources.exit_48px;
            toolStripButton7.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton7.ImageTransparentColor = Color.Magenta;
            toolStripButton7.Name = "toolStripButton7";
            toolStripButton7.Size = new Size(52, 72);
            toolStripButton7.Text = "Salir";
            toolStripButton7.TextImageRelation = TextImageRelation.ImageAboveText;
            toolStripButton7.Click += toolStripButton7_Click;
            // 
            // panelCantidad
            // 
            panelCantidad.Controls.Add(txtCantidad);
            panelCantidad.Controls.Add(label1);
            panelCantidad.Dock = DockStyle.Bottom;
            panelCantidad.Location = new Point(0, 492);
            panelCantidad.Margin = new Padding(3, 4, 3, 4);
            panelCantidad.Name = "panelCantidad";
            panelCantidad.Size = new Size(874, 97);
            panelCantidad.TabIndex = 1;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(146, 33);
            txtCantidad.Margin = new Padding(3, 4, 3, 4);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.ReadOnly = true;
            txtCantidad.Size = new Size(114, 27);
            txtCantidad.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 37);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 0;
            label1.Text = "Cantidad";
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dgvDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colMayor, colMenor, colBorde, colColor, colPerimetro, colArea });
            dgvDatos.Dock = DockStyle.Fill;
            dgvDatos.Location = new Point(0, 75);
            dgvDatos.Margin = new Padding(3, 4, 3, 4);
            dgvDatos.MultiSelect = false;
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.RowHeadersVisible = false;
            dgvDatos.RowHeadersWidth = 51;
            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatos.Size = new Size(874, 417);
            dgvDatos.TabIndex = 2;
            // 
            // colMayor
            // 
            colMayor.HeaderText = "Semieje Mayor";
            colMayor.MinimumWidth = 6;
            colMayor.Name = "colMayor";
            colMayor.ReadOnly = true;
            colMayor.Width = 125;
            // 
            // colMenor
            // 
            colMenor.HeaderText = "Semieje Menor";
            colMenor.MinimumWidth = 6;
            colMenor.Name = "colMenor";
            colMenor.ReadOnly = true;
            colMenor.Width = 125;
            // 
            // colBorde
            // 
            colBorde.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colBorde.HeaderText = "Borde";
            colBorde.MinimumWidth = 6;
            colBorde.Name = "colBorde";
            colBorde.ReadOnly = true;
            // 
            // colColor
            // 
            colColor.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colColor.HeaderText = "Color";
            colColor.MinimumWidth = 6;
            colColor.Name = "colColor";
            colColor.ReadOnly = true;
            // 
            // colPerimetro
            // 
            colPerimetro.HeaderText = "Perímetro";
            colPerimetro.MinimumWidth = 6;
            colPerimetro.Name = "colPerimetro";
            colPerimetro.ReadOnly = true;
            colPerimetro.Width = 125;
            // 
            // colArea
            // 
            colArea.HeaderText = "Área";
            colArea.MinimumWidth = 6;
            colArea.Name = "colArea";
            colArea.ReadOnly = true;
            colArea.Width = 125;
            // 
            // frmElipses
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(874, 589);
            Controls.Add(dgvDatos);
            Controls.Add(panelCantidad);
            Controls.Add(toolStrip1);
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(892, 636);
            MinimumSize = new Size(892, 636);
            Name = "frmElipses";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Listado de Elipses";
            Load += Form1_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panelCantidad.ResumeLayout(false);
            panelCantidad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButton6;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton toolStripButton7;
        private Panel panelCantidad;
        private TextBox txtCantidad;
        private Label label1;
        private DataGridView dgvDatos;
        private DataGridViewTextBoxColumn colMayor;
        private DataGridViewTextBoxColumn colMenor;
        private DataGridViewTextBoxColumn colBorde;
        private DataGridViewTextBoxColumn colColor;
        private DataGridViewTextBoxColumn colPerimetro;
        private DataGridViewTextBoxColumn colArea;
        private ToolStripDropDownButton toolStripButton4;
        private ToolStripMenuItem bordeToolStripMenuItem;
        private ToolStripComboBox tsCboBordes;
        private ToolStripDropDownButton toolStripButton5;
        private ToolStripMenuItem área09ToolStripMenuItem;
        private ToolStripMenuItem área90ToolStripMenuItem;
    }
}
