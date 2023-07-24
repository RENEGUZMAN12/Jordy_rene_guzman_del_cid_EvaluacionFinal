
namespace Analisis_y_visualizacion_de_datos
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.txt_nombre_datos = new System.Windows.Forms.TextBox();
            this.btn_añadir_datos_dtg = new System.Windows.Forms.Button();
            this.chart_graficacion = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.DTG_tabla_datos = new System.Windows.Forms.DataGridView();
            this.txt_cifra_dato = new System.Windows.Forms.TextBox();
            this.btn_graficar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart_graficacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTG_tabla_datos)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_nombre_datos
            // 
            this.txt_nombre_datos.Location = new System.Drawing.Point(87, 131);
            this.txt_nombre_datos.Name = "txt_nombre_datos";
            this.txt_nombre_datos.Size = new System.Drawing.Size(100, 26);
            this.txt_nombre_datos.TabIndex = 0;
            // 
            // btn_añadir_datos_dtg
            // 
            this.btn_añadir_datos_dtg.Location = new System.Drawing.Point(191, 184);
            this.btn_añadir_datos_dtg.Name = "btn_añadir_datos_dtg";
            this.btn_añadir_datos_dtg.Size = new System.Drawing.Size(107, 38);
            this.btn_añadir_datos_dtg.TabIndex = 1;
            this.btn_añadir_datos_dtg.Text = "Añadir datos";
            this.btn_añadir_datos_dtg.UseVisualStyleBackColor = true;
            this.btn_añadir_datos_dtg.Click += new System.EventHandler(this.btn_añadir_datos_dtg_Click);
            // 
            // chart_graficacion
            // 
            chartArea3.Name = "ChartArea1";
            this.chart_graficacion.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart_graficacion.Legends.Add(legend3);
            this.chart_graficacion.Location = new System.Drawing.Point(591, 131);
            this.chart_graficacion.Name = "chart_graficacion";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart_graficacion.Series.Add(series3);
            this.chart_graficacion.Size = new System.Drawing.Size(483, 390);
            this.chart_graficacion.TabIndex = 2;
            this.chart_graficacion.Text = "chart1";
            // 
            // DTG_tabla_datos
            // 
            this.DTG_tabla_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTG_tabla_datos.Location = new System.Drawing.Point(27, 228);
            this.DTG_tabla_datos.Name = "DTG_tabla_datos";
            this.DTG_tabla_datos.RowHeadersWidth = 62;
            this.DTG_tabla_datos.RowTemplate.Height = 28;
            this.DTG_tabla_datos.Size = new System.Drawing.Size(430, 293);
            this.DTG_tabla_datos.TabIndex = 3;
            // 
            // txt_cifra_dato
            // 
            this.txt_cifra_dato.Location = new System.Drawing.Point(297, 131);
            this.txt_cifra_dato.Name = "txt_cifra_dato";
            this.txt_cifra_dato.Size = new System.Drawing.Size(100, 26);
            this.txt_cifra_dato.TabIndex = 4;
            // 
            // btn_graficar
            // 
            this.btn_graficar.Location = new System.Drawing.Point(784, 87);
            this.btn_graficar.Name = "btn_graficar";
            this.btn_graficar.Size = new System.Drawing.Size(140, 38);
            this.btn_graficar.TabIndex = 5;
            this.btn_graficar.Text = "Graficar datos";
            this.btn_graficar.UseVisualStyleBackColor = true;
            this.btn_graficar.Click += new System.EventHandler(this.btn_graficar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1035, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 61);
            this.button1.TabIndex = 6;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre dato";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cifra del dato";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 612);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_graficar);
            this.Controls.Add(this.txt_cifra_dato);
            this.Controls.Add(this.DTG_tabla_datos);
            this.Controls.Add(this.chart_graficacion);
            this.Controls.Add(this.btn_añadir_datos_dtg);
            this.Controls.Add(this.txt_nombre_datos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_graficacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTG_tabla_datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nombre_datos;
        private System.Windows.Forms.Button btn_añadir_datos_dtg;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_graficacion;
        private System.Windows.Forms.DataGridView DTG_tabla_datos;
        private System.Windows.Forms.TextBox txt_cifra_dato;
        private System.Windows.Forms.Button btn_graficar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

