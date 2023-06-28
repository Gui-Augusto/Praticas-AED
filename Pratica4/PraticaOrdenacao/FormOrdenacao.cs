using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace Pratica5 {
    public partial class FormOrdenacao : Form {
        
        int tamanho;
        int[] vet; // vetor interno para a animação
        string preenchimentovetor = "Aleatorio";
        
        

        public FormOrdenacao() {
            InitializeComponent();
            panel.Paint += new PaintEventHandler(panel_Paint);
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, panel, new object[] { true });
        }

        private void panel_Paint(object sender, PaintEventArgs e) {
            for (int i = 0; i < vet.Length; i++) {
                e.Graphics.DrawLine(Pens.Green, i, 299, i, 299 - vet[i]);
            }
        }

        

        // TODO: animação e estatísticas dos demais métodos de ordenação

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show(this, 
                "Prática 5 2023/1 - Métodos de Ordenação\n\n" +
                "Desenvolvido por:\n72201100 - Guilherme Augusto\n" +
                "Prof. Virgílio Borges de Oliveira\n\n" +
                "Algoritmos e Estruturas de Dados\n" +
                "Faculdade COTEMIG\n" +
                "Apenas para fins didáticos.", 
                "Trabalho com objetivo de relatar os métodos de ordenação e sua velocidade com diferentes tipos de vetor ", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }

        private void iniciaAnimacao(Action a) {
            if (bgw.IsBusy != true) {
                if (preenchimentovetor == "Aleatorio")
                    Preenchimento.Aleatorio(vet, 300);
                if (preenchimentovetor == "Crescente")
                    Preenchimento.Crescente(vet, 300);
                if (preenchimentovetor == "Decrescente")
                    Preenchimento.Decrescente(vet, 300);

                bgw.RunWorkerAsync(a);
            }
            else {
                MessageBox.Show(this,
                   "Aguarde o fim da execução atual...",
                   "Prática 5 2023/1 - Métodos de Ordenação",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Exclamation);
            }
        }

        private void bgw_DoWork(object sender, DoWorkEventArgs e) {
            Action a = (Action)e.Argument;
            a();
        }

        private void bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            MessageBox.Show(this,
               "Animação concluída!",
               "Prática 5 2023/1 - Métodos de Ordenação",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information);
        }



        private void seleçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iniciaAnimacao(() => OrdenacaoGrafica.selecao(vet, panel));
        }
        private void bolhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iniciaAnimacao(() => OrdenacaoGrafica.Bolha(vet, panel));
        }

        private void shellsortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iniciaAnimacao(() => OrdenacaoGrafica.shellSort(vet, panel));
        }

        private void inserçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iniciaAnimacao(() => OrdenacaoGrafica.insercao(vet, panel));
        }

        private void heapsortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iniciaAnimacao(() => OrdenacaoGrafica.heapSort(vet, panel));
        }

        private void quicksortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int esq = 0;
            int dir = vet.Length - 1;
            iniciaAnimacao(() => OrdenacaoGrafica.quickSort(vet, esq,dir, panel));
        }

        private void mergesortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = 0;
            int j = vet.Length - 1;
            iniciaAnimacao(() => OrdenacaoGrafica.mergeSort(vet, i, j, panel));
        }

        private void FormOrdenacao_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) // aleatorio
        {
            preenchimentovetor = "Aleatorio";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e) // crescente
        {
            preenchimentovetor = "Crescente";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) // decrescente 
        {
            preenchimentovetor = "Decrescente";
        }

 

        private void radioButton7_CheckedChanged(object sender, EventArgs e) // 10.000
        {
            tamanho = 10000;
            vet = new int[tamanho];
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e) // 100.000
        {
            tamanho = 100000;
            vet = new int[tamanho];
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e) // 50.000
        {
            tamanho = 50000;
            vet = new int[tamanho];
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e) // 500.000
        {
            tamanho = 500000;
            vet = new int[tamanho];
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            tamanho = 500;
            vet = new int[tamanho];
        }

        private void bolhaToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {

            int[] vetor = new int[tamanho]; // TODO (tamanho deverá ser escolhido pelo usuário)

            if (preenchimentovetor == "Aleatorio")
                Preenchimento.Aleatorio(vetor, 300);
            if (preenchimentovetor == "Crescente")
                Preenchimento.Crescente(vetor, 300);
            if (preenchimentovetor == "Decrescente")
                Preenchimento.Decrescente(vetor, 300);

            var stopwatch = new Stopwatch();
            stopwatch.Start(); // inicia cronômetro
            OrdenacaoEstatistica.Bolha(vetor);
            stopwatch.Stop(); // interrompe cronômetro
            long elapsed_time = stopwatch.ElapsedMilliseconds; // calcula o tempo decorrido
            MessageBox.Show(this,
                  "Tamanho do vetor: " + tamanho+
                  "\nOrdenação inicial: " +preenchimentovetor+
                  "\n\nTempo de execução: " + String.Format("{0:F4} seg", elapsed_time / 1000.0) +
                  "\nNº de comparações: "+ OrdenacaoEstatistica.cont_c +
                  "\nNº de trocas: " +OrdenacaoEstatistica.cont_t,  
                  "Estatísticas do Método Bolha",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
        }
        private void seleçãoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[tamanho]; // TODO (tamanho deverá ser escolhido pelo usuário)

            if (preenchimentovetor == "Aleatorio")
                Preenchimento.Aleatorio(vetor, 300);
            if (preenchimentovetor == "Crescente")
                Preenchimento.Crescente(vetor, 300);
            if (preenchimentovetor == "Decrescente")
                Preenchimento.Decrescente(vetor, 300);

            var stopwatch = new Stopwatch();
            stopwatch.Start(); // inicia cronômetro
            OrdenacaoEstatistica.selecao(vetor);
            stopwatch.Stop(); // interrompe cronômetro
            long elapsed_time = stopwatch.ElapsedMilliseconds; // calcula o tempo decorrido
            MessageBox.Show(this,
                  "Tamanho do vetor: " + tamanho +
                  "\nOrdenação inicial: " + preenchimentovetor +
                  "\n\nTempo de execução: " + String.Format("{0:F4} seg", elapsed_time / 1000.0) +
                  "\nNº de comparações: " + OrdenacaoEstatistica.cont_c +
                  "\nNº de trocas: " + OrdenacaoEstatistica.cont_t,
                  "Estatísticas do Método Seleção",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);

        }

        private void shellsortToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[tamanho]; // TODO (tamanho deverá ser escolhido pelo usuário)

            if (preenchimentovetor == "Aleatorio")
                Preenchimento.Aleatorio(vetor, 300);
            if (preenchimentovetor == "Crescente")
                Preenchimento.Crescente(vetor, 300);
            if (preenchimentovetor == "Decrescente")
                Preenchimento.Decrescente(vetor, 300);

            var stopwatch = new Stopwatch();
            stopwatch.Start(); // inicia cronômetro
            OrdenacaoEstatistica.shellSort(vetor);
            stopwatch.Stop(); // interrompe cronômetro
            long elapsed_time = stopwatch.ElapsedMilliseconds; // calcula o tempo decorrido
            MessageBox.Show(this,
                  "Tamanho do vetor: " + tamanho +
                  "\nOrdenação inicial: " + preenchimentovetor +
                  "\n\nTempo de execução: " + String.Format("{0:F4} seg", elapsed_time / 1000.0) +
                  "\nNº de comparações: " + OrdenacaoEstatistica.cont_c +
                  "\nNº de trocas: " + OrdenacaoEstatistica.cont_t,
                  "Estatísticas do Método Shellsort",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
        }

        private void heapsortToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[tamanho]; // TODO (tamanho deverá ser escolhido pelo usuário)

            if (preenchimentovetor == "Aleatorio")
                Preenchimento.Aleatorio(vetor, 300);
            if (preenchimentovetor == "Crescente")
                Preenchimento.Crescente(vetor, 300);
            if (preenchimentovetor == "Decrescente")
                Preenchimento.Decrescente(vetor, 300);

            var stopwatch = new Stopwatch();
            stopwatch.Start(); // inicia cronômetro
            OrdenacaoEstatistica.heapSort(vetor);
            stopwatch.Stop(); // interrompe cronômetro
            long elapsed_time = stopwatch.ElapsedMilliseconds; // calcula o tempo decorrido
            MessageBox.Show(this,
                  "Tamanho do vetor: " + tamanho +
                  "\nOrdenação inicial: " + preenchimentovetor +
                  "\n\nTempo de execução: " + String.Format("{0:F4} seg", elapsed_time / 1000.0) +
                  "\nNº de comparações: " + OrdenacaoEstatistica.cont_c +
                  "\nNº de trocas: " + OrdenacaoEstatistica.cont_t,
                  "Estatísticas do Método Heapsort",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
        }

        private void quicksortToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int esq = 0;
            int dir = vet.Length - 1;
            int[] vetor = new int[tamanho]; // TODO (tamanho deverá ser escolhido pelo usuário)

            if (preenchimentovetor == "Aleatorio")
                Preenchimento.Aleatorio(vetor, 300);
            if (preenchimentovetor == "Crescente")
                Preenchimento.Crescente(vetor, 300);
            if (preenchimentovetor == "Decrescente")
                Preenchimento.Decrescente(vetor, 300);

            var stopwatch = new Stopwatch();
            stopwatch.Start(); // inicia cronômetro
            OrdenacaoEstatistica.quickSort(vetor,esq,dir);
            stopwatch.Stop(); // interrompe cronômetro
            long elapsed_time = stopwatch.ElapsedMilliseconds; // calcula o tempo decorrido
            MessageBox.Show(this,
                  "Tamanho do vetor: " + tamanho +
                  "\nOrdenação inicial: " + preenchimentovetor +
                  "\n\nTempo de execução: " + String.Format("{0:F4} seg", elapsed_time / 1000.0) +
                  "\nNº de comparações: " + OrdenacaoEstatistica.cont_c +
                  "\nNº de trocas: " + OrdenacaoEstatistica.cont_t,
                  "Estatísticas do Método Quicksort",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
        }

        private void mergesortToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int i = 0;
            int j = vet.Length - 1;
            int[] vetor = new int[tamanho]; // TODO (tamanho deverá ser escolhido pelo usuário)

            if (preenchimentovetor == "Aleatorio")
                Preenchimento.Aleatorio(vetor, 300);
            if (preenchimentovetor == "Crescente")
                Preenchimento.Crescente(vetor, 300);
            if (preenchimentovetor == "Decrescente")
                Preenchimento.Decrescente(vetor, 300);
            OrdenacaoEstatistica.cont_c = 0;
            OrdenacaoEstatistica.cont_t = 0;
            var stopwatch = new Stopwatch();
            stopwatch.Start(); // inicia cronômetro
            OrdenacaoEstatistica.mergeSort(vetor,i,j);
            stopwatch.Stop(); // interrompe cronômetro
            long elapsed_time = stopwatch.ElapsedMilliseconds; // calcula o tempo decorrido
            MessageBox.Show(this,
                  "Tamanho do vetor: " + tamanho +
                  "\nOrdenação inicial: " + preenchimentovetor +
                  "\n\nTempo de execução: " + String.Format("{0:F4} seg", elapsed_time / 1000.0) +
                  "\nNº de comparações: " + OrdenacaoEstatistica.cont_c +
                  "\nNº de trocas: " + OrdenacaoEstatistica.cont_t,
                  "Estatísticas do Método Mergesort",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
        }

        private void inserçãoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[tamanho]; // TODO (tamanho deverá ser escolhido pelo usuário)

            if (preenchimentovetor == "Aleatorio")
                Preenchimento.Aleatorio(vetor, 300);
            if (preenchimentovetor == "Crescente")
                Preenchimento.Crescente(vetor, 300);
            if (preenchimentovetor == "Decrescente")
                Preenchimento.Decrescente(vetor, 300);

            var stopwatch = new Stopwatch();
            stopwatch.Start(); // inicia cronômetro
            OrdenacaoEstatistica.insercao(vetor);
            stopwatch.Stop(); // interrompe cronômetro
            long elapsed_time = stopwatch.ElapsedMilliseconds; // calcula o tempo decorrido
            MessageBox.Show(this,
                  "Tamanho do vetor: " + tamanho +
                  "\nOrdenação inicial: " + preenchimentovetor +
                  "\n\nTempo de execução: " + String.Format("{0:F4} seg", elapsed_time / 1000.0) +
                  "\nNº de comparações: " + OrdenacaoEstatistica.cont_c +
                  "\nNº de trocas: " + OrdenacaoEstatistica.cont_t,
                  "Estatísticas do Método Inserção",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
        }
    }

}
