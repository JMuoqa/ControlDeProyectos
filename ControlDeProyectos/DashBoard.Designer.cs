using System.Windows.Forms;
using System.Drawing;
using ControlDeProyectos.ElementosPersonalizados;
namespace ControlDeProyectos
{
    partial class DashBoard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panel_circulo = new PanelPer();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel_lineas = new PanelPer();
            panel_circulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // panel_circulo
            // 
            panel_circulo.BackColor = Color.FromArgb(222, 205, 179);
            panel_circulo.Controls.Add(chart1);
            panel_circulo.Location = new Point(40, 40);
            panel_circulo.Name = "panel_circulo";
            panel_circulo.Size = new Size(410, 285);
            panel_circulo.TabIndex = 0;
            // 
            // chart1
            // 
            chart1.BackColor = Color.FromArgb(222, 205, 179);
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(47, 47);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(300, 193);
            chart1.TabIndex = 0;
            chart1.Text = "chart1";
            // 
            // panel_lineas
            // 
            panel_lineas.BackColor = Color.FromArgb(222, 205, 179);
            panel_lineas.Location = new Point(40, 381);
            panel_lineas.Name = "panel_lineas";
            panel_lineas.Size = new Size(511, 285);
            panel_lineas.TabIndex = 1;
            // 
            // DashBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 225, 199);
            ClientSize = new Size(933, 726);
            Controls.Add(panel_lineas);
            Controls.Add(panel_circulo);
            Font = new Font("Montserrat", 10F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "DashBoard";
            Text = "DashBoard";
            panel_circulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PanelPer panel_circulo;
        private PanelPer panel_lineas;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}