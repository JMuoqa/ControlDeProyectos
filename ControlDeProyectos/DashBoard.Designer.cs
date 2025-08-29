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
            estadisticas_circulo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel_lineas = new PanelPer();
            panel_circulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)estadisticas_circulo).BeginInit();
            SuspendLayout();
            // 
            // panel_circulo
            // 
            panel_circulo.BackColor = Color.FromArgb(222, 205, 179);
            panel_circulo.Controls.Add(estadisticas_circulo);
            panel_circulo.Location = new Point(40, 40);
            panel_circulo.Name = "panel_circulo";
            panel_circulo.Size = new Size(410, 285);
            panel_circulo.TabIndex = 0;
            // 
            // estadisticas_circulo
            // 
            estadisticas_circulo.BackColor = Color.FromArgb(222, 205, 179);
            chartArea1.Name = "ChartArea1";
            estadisticas_circulo.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            estadisticas_circulo.Legends.Add(legend1);
            estadisticas_circulo.Location = new Point(55, 33);
            estadisticas_circulo.Name = "estadisticas_circulo";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "Ingresos";
            estadisticas_circulo.Series.Add(series1);
            estadisticas_circulo.Size = new Size(300, 193);
            estadisticas_circulo.TabIndex = 0;
            estadisticas_circulo.Text = "chart1";
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
            ((System.ComponentModel.ISupportInitialize)estadisticas_circulo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PanelPer panel_circulo;
        private PanelPer panel_lineas;
        private System.Windows.Forms.DataVisualization.Charting.Chart estadisticas_circulo;
    }
}