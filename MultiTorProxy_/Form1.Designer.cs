namespace MultiTorProxy_
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelPrincipal = new System.Windows.Forms.FlowLayoutPanel();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(261, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "ProxyGlobalWindows";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(425, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "ProxyChrome";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(748, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "ProxyFirefox";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(585, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "ProxyOpera";
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelPrincipal.Location = new System.Drawing.Point(12, 50);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(930, 606);
            this.panelPrincipal.TabIndex = 9;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 20);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "Nuevo Tor Proxy";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 688);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form1";
            this.Text = "MultiTorProxy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        public  System.Windows.Forms.GroupBox CrearBoxTor(int i)
        {


            System.Windows.Forms.Label ipYPuerto = new System.Windows.Forms.Label();

        // 
        // ipYPuerto
        // 
            ipYPuerto.AutoSize = true;
            ipYPuerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ipYPuerto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            ipYPuerto.Location = new System.Drawing.Point(3, 0);
            ipYPuerto.Name = "ipYPuerto"+"_"+i.ToString();
            ipYPuerto.Size = new System.Drawing.Size(100, 20);
            ipYPuerto.TabIndex = 2;
            ipYPuerto.Text = "127.0.0.1:0000";
            ipYPuerto.ForeColor = System.Drawing.Color.Red;
            ipYPuerto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            

            listaDeIpYPuerto[i] = ipYPuerto;



            System.Windows.Forms.Label ipTor = new System.Windows.Forms.Label();
            // 
            // ipTor
            // 
            ipTor.AutoSize = true;
            ipTor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ipTor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            ipTor.Location = new System.Drawing.Point(3, 13);
            ipTor.Name = "ipTor" + "_" + i.ToString();
            ipTor.Size = new System.Drawing.Size(100, 20);
            ipTor.TabIndex = 2;
            ipTor.Text = "0.0.0.0";
            ipTor.ForeColor = System.Drawing.Color.Red;
            ipTor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            
            listaDeIpTor[i] = ipTor;

           
            System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            flowLayoutPanel1.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(listaDeIpYPuerto[i]);
            flowLayoutPanel1.Controls.Add(listaDeIpTor[i]);
            flowLayoutPanel1.Location = new System.Drawing.Point(84, 12);
            flowLayoutPanel1.Name = "flowLayoutPanel1" + "_" + i.ToString();
            flowLayoutPanel1.Size = new System.Drawing.Size(160, 40);
            flowLayoutPanel1.TabIndex = 8;
            flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown; 

            System.Windows.Forms.Button button3 = new System.Windows.Forms.Button();
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(3, 19);
            button3.Name = "button1"+"_"+i.ToString();
            button3.Size = new System.Drawing.Size(75, 23);
            button3.Tag = i; 
            button3.TabIndex = 4;
            button3.Text = "Iniciar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += new System.EventHandler(Button1_Click);



            System.Windows.Forms.CheckBox checkBox1 = new System.Windows.Forms.CheckBox();
            // 
            // checkBox1
            // 


            checkBox1.AutoSize = true;
            checkBox1.Location = new System.Drawing.Point(250, 22);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new System.Drawing.Size(85, 17);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Desconectado";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.Tag = i;
            checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);

            System.Windows.Forms.CheckBox checkBox2 = new System.Windows.Forms.CheckBox();
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new System.Drawing.Point(416, 22);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new System.Drawing.Size(85, 17);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Desconectado";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.Tag = i;
            checkBox2.CheckedChanged += new System.EventHandler(this.CheckBox2_CheckedChanged);

            System.Windows.Forms.CheckBox checkBox3 = new System.Windows.Forms.CheckBox();
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new System.Drawing.Point(577, 22);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new System.Drawing.Size(85, 17);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "Desconectado";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.Tag = i;
            checkBox3.CheckedChanged += new System.EventHandler(this.CheckBox3_CheckedChanged);

            System.Windows.Forms.CheckBox checkBox4 = new System.Windows.Forms.CheckBox();
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new System.Drawing.Point(742, 22);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new System.Drawing.Size(85, 17);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "Desconectado";
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.Tag = i;
            checkBox4.CheckedChanged += new System.EventHandler(this.CheckBox4_CheckedChanged);


            System.Windows.Forms.GroupBox boxTor = new System.Windows.Forms.GroupBox();
            boxTor.SuspendLayout();
            // 
            // groupBox1
            // 
            boxTor.Controls.Add(flowLayoutPanel1);
            boxTor.Controls.Add(button3);
            boxTor.Controls.Add(checkBox4);
            boxTor.Controls.Add(checkBox3);
            boxTor.Controls.Add(checkBox2);
            boxTor.Controls.Add(checkBox1);
            boxTor.Location = new System.Drawing.Point(3, 41);
            boxTor.Name = "groupBox1_"+i.ToString();
            boxTor.Size = new System.Drawing.Size(926, 61);
            boxTor.TabIndex = 4;
            boxTor.TabStop = false;
            boxTor.Text = "_- Tor Proxy "+ i.ToString()+" -_";


            return boxTor;


        }


        #endregion



        public static System.Windows.Forms.Label[] listaDeIpYPuerto= new System.Windows.Forms.Label[1000];
        public static System.Windows.Forms.Label[] listaDeIpTor = new System.Windows.Forms.Label[1000];


        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        internal System.Windows.Forms.FlowLayoutPanel panelPrincipal;
        private System.Windows.Forms.Button button4;
    }
}

