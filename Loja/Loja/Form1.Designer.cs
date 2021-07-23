
namespace Loja
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmEstoque = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEntrada = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSaida = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmInfoSistema = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCadastro,
            this.tsmEstoque,
            this.tsmSobre});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmCadastro
            // 
            this.tsmCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmProdutos,
            this.tsmUsuarios});
            this.tsmCadastro.Name = "tsmCadastro";
            this.tsmCadastro.Size = new System.Drawing.Size(66, 20);
            this.tsmCadastro.Text = "Cadastro";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tsmEstoque
            // 
            this.tsmEstoque.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmEntrada,
            this.tsmSaida});
            this.tsmEstoque.Name = "tsmEstoque";
            this.tsmEstoque.Size = new System.Drawing.Size(61, 20);
            this.tsmEstoque.Text = "Estoque";
            // 
            // tsmSobre
            // 
            this.tsmSobre.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmInfoSistema});
            this.tsmSobre.Name = "tsmSobre";
            this.tsmSobre.Size = new System.Drawing.Size(49, 20);
            this.tsmSobre.Text = "Sobre";
            // 
            // tsmProdutos
            // 
            this.tsmProdutos.Name = "tsmProdutos";
            this.tsmProdutos.Size = new System.Drawing.Size(180, 22);
            this.tsmProdutos.Text = "Produtos";
            // 
            // tsmUsuarios
            // 
            this.tsmUsuarios.Name = "tsmUsuarios";
            this.tsmUsuarios.Size = new System.Drawing.Size(180, 22);
            this.tsmUsuarios.Text = "Usuários";
            this.tsmUsuarios.Click += new System.EventHandler(this.tsmUsuarios_Click);
            // 
            // tsmEntrada
            // 
            this.tsmEntrada.Name = "tsmEntrada";
            this.tsmEntrada.Size = new System.Drawing.Size(180, 22);
            this.tsmEntrada.Text = "Entrada";
            // 
            // tsmSaida
            // 
            this.tsmSaida.Name = "tsmSaida";
            this.tsmSaida.Size = new System.Drawing.Size(180, 22);
            this.tsmSaida.Text = "Saída";
            // 
            // tsmInfoSistema
            // 
            this.tsmInfoSistema.Name = "tsmInfoSistema";
            this.tsmInfoSistema.Size = new System.Drawing.Size(201, 22);
            this.tsmInfoSistema.Text = "Informações do Sistema";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Cadastro de Usuários";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmCadastro;
        private System.Windows.Forms.ToolStripMenuItem tsmEstoque;
        private System.Windows.Forms.ToolStripMenuItem tsmSobre;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmProdutos;
        private System.Windows.Forms.ToolStripMenuItem tsmUsuarios;
        private System.Windows.Forms.ToolStripMenuItem tsmEntrada;
        private System.Windows.Forms.ToolStripMenuItem tsmSaida;
        private System.Windows.Forms.ToolStripMenuItem tsmInfoSistema;
    }
}

