using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_tac_toe
{
    public partial class FrmBoard : Form
    {
        int m, mx, my;

        // El tablero del juego
        // Si el elemento es 0, la casilla está vacía
        // Si el elemento es 1, la casilla está marcada por el jugador
        // Si el elemento es 2, la casilla está marcada por el oponente
        private static int[] board;

        // El turno del jugador (par o impar)
        private static int turn;

        private int nGames;

        private bool isJvsJ;

        private bool isCPUvsCPU;

        private bool gameOver = false;


        public FrmBoard()
        {
            InitializeComponent();
            turn = 0;
            nGames = 0;
            isJvsJ = false;
            isCPUvsCPU = false;
            board = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        }

        public FrmBoard(bool jVSj)
        {
            InitializeComponent();
            lbTitle.Text = "Jugador VS Jugador";
            turn = 0;
            nGames = 0;
            this.isJvsJ = jVSj;
            isCPUvsCPU = false;
            board = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        }

        public FrmBoard(String cpu, bool isCPUvsCPU)
        {
            InitializeComponent();
            lbTitle.Text = "CPU VS CPU";
            turn = 0;
            nGames = 0;
            board = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            this.isCPUvsCPU = isCPUvsCPU;
            disableBtns();
            btnStart.Visible = true;
        }

        // metodos para poder arrastrar las ventanas
        private void pnlArrastrar_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        private void pnlArrastrar_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        private void pnlArrastrar_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }


        private void playerMove(int playerMove, int j)
        {
            int score = Evaluate(board);

            if (IsMovesLeft(board) && score == 0)
            {
                // Validar que el movimiento sea válido
                if (board[playerMove] == 0)
                {
                    // Marcar la casilla
                    board[playerMove] = j;
                    // Incrementar el turno
                    turn++;

                    if (!isJvsJ)
                    {
                        // Mostrar el tablero actualizado
                        cpuMove();
                    }
                }
            }

            endMessage();
        }

        // Función que muestra el tiro del CPU en el tablero
        async private void cpuMove()
        {
            int score = Evaluate(board);


            if (IsMovesLeft(board) && score == 0)
            {
                // Aplicar el algoritmo minimax para encontrar el mejor movimiento
                int opponentMove = Minimax(board, 0, false).Item1;

                if (turn % 2 == 0)
                {
                    // Marcar la casilla con 1
                    board[opponentMove] = 1;
                }
                else
                {
                    // Marcar la casilla con 2
                    board[opponentMove] = 2;
                }

                switch (opponentMove)
                {
                    case 0:
                        btnCasilla0.Enabled = false;
                        if (turn % 2 != 0)
                        {
                            pbCasilla0.Visible = true;
                            pbCasilla0.Image = Properties.Resources.Circulo;
                            await PausaAsync(400);
                            pbCasilla0.Image = Properties.Resources.C_1;
                        }
                        else
                        {
                            pbCasilla0.Visible = true;
                            pbCasilla0.Image = Properties.Resources.Cruz;
                            await PausaAsync(400);
                            pbCasilla0.Image = Properties.Resources.X_1;
                        }
                        break;
                    case 1:
                        btnCasilla1.Enabled = false;
                        if (turn % 2 != 0)
                        {
                            pbCasilla1.Visible = true;
                            pbCasilla1.Image = Properties.Resources.Circulo;
                            await PausaAsync(400);
                            pbCasilla1.Image = Properties.Resources.C_1;
                        }
                        else
                        {
                            pbCasilla1.Visible = true;
                            pbCasilla1.Image = Properties.Resources.Cruz;
                            await PausaAsync(400);
                            pbCasilla1.Image = Properties.Resources.X_1;
                        }
                        break;
                    case 2:
                        btnCasilla2.Enabled = false;
                        if (turn % 2 != 0)
                        {
                            pbCasilla2.Visible = true;
                            pbCasilla2.Image = Properties.Resources.Circulo;
                            await PausaAsync(400);
                            pbCasilla2.Image = Properties.Resources.C_1;
                        }
                        else
                        {
                            pbCasilla2.Visible = true;
                            pbCasilla2.Image = Properties.Resources.Cruz;
                            await PausaAsync(400);
                            pbCasilla2.Image = Properties.Resources.X_1;
                        }
                        break;
                    case 3:
                        btnCasilla3.Enabled = false;
                        if (turn % 2 != 0)
                        {
                            pbCasilla3.Visible = true;
                            pbCasilla3.Image = Properties.Resources.Circulo;
                            await PausaAsync(400);
                            pbCasilla3.Image = Properties.Resources.C_1;
                        }
                        else
                        {
                            pbCasilla3.Visible = true;
                            pbCasilla3.Image = Properties.Resources.Cruz;
                            await PausaAsync(400);
                            pbCasilla3.Image = Properties.Resources.X_1;
                        }
                        break;
                    case 4:
                        btnCasilla4.Enabled = false;
                        if (turn % 2 != 0)
                        {
                            pbCasilla4.Visible = true;
                            pbCasilla4.Image = Properties.Resources.Circulo;
                            await PausaAsync(400);
                            pbCasilla4.Image = Properties.Resources.C_1;
                        }
                        else
                        {
                            pbCasilla4.Visible = true;
                            pbCasilla4.Image = Properties.Resources.Cruz;
                            await PausaAsync(400);
                            pbCasilla4.Image = Properties.Resources.X_1;
                        }
                        break;
                    case 5:
                        btnCasilla5.Enabled = false;
                        if (turn % 2 != 0)
                        {
                            pbCasilla5.Visible = true;
                            pbCasilla5.Image = Properties.Resources.Circulo;
                            await PausaAsync(400);
                            pbCasilla5.Image = Properties.Resources.C_1;
                        }
                        else
                        {
                            pbCasilla5.Visible = true;
                            pbCasilla5.Image = Properties.Resources.Cruz;
                            await PausaAsync(400);
                            pbCasilla5.Image = Properties.Resources.X_1;
                        }
                        break;
                    case 6:
                        btnCasilla6.Enabled = false;
                        if (turn % 2 != 0)
                        {
                            pbCasilla6.Visible = true;
                            pbCasilla6.Image = Properties.Resources.Circulo;
                            await PausaAsync(400);
                            pbCasilla6.Image = Properties.Resources.C_1;
                        }
                        else
                        {
                            pbCasilla6.Visible = true;
                            pbCasilla6.Image = Properties.Resources.Cruz;
                            await PausaAsync(400);
                            pbCasilla6.Image = Properties.Resources.X_1;
                        }
                        break;
                    case 7:
                        btnCasilla7.Enabled = false;
                        if (turn % 2 != 0)
                        {
                            pbCasilla7.Visible = true;
                            pbCasilla7.Image = Properties.Resources.Circulo;
                            await PausaAsync(400);
                            pbCasilla7.Image = Properties.Resources.C_1;
                        }
                        else
                        {
                            pbCasilla7.Visible = true;
                            pbCasilla7.Image = Properties.Resources.Cruz;
                            await PausaAsync(400);
                            pbCasilla7.Image = Properties.Resources.X_1;
                        }
                        break;
                    case 8:
                        btnCasilla8.Enabled = false;
                        if (turn % 2 != 0)
                        {
                            pbCasilla8.Visible = true;
                            pbCasilla8.Image = Properties.Resources.Circulo;
                            await PausaAsync(400);
                            pbCasilla8.Image = Properties.Resources.C_1;
                        }
                        else
                        {
                            pbCasilla8.Visible = true;
                            pbCasilla8.Image = Properties.Resources.Cruz;
                            await PausaAsync(400);
                            pbCasilla8.Image = Properties.Resources.X_1;
                        }
                        break;

                }

                // Incrementar el turno
                turn++;
            }

        }

        async private void cpuVScpuControl()
        {
            await PausaAsync(800);
            cpuMove();
            await PausaAsync(800);
            cpuMove();

            endMessage();

            if (!gameOver)
            {
                cpuVScpuControl();
            }
        }

        private void endMessage()
        {
            int score = Evaluate(board);

            if (score == 10)
            {
                MessageBox.Show("Las X han ganado");
                gameOver = true;
                gunaGradientButton1.Visible = true;
                gunaGradientButton1.BringToFront();
            }
            else if (score == -10)
            {
                MessageBox.Show("Las O han ganado");
                gameOver = true;
                gunaGradientButton1.Visible = true;
                gunaGradientButton1.BringToFront();
            }
            else if (!IsMovesLeft(board) && score == 0)
            {
                MessageBox.Show("El juego ha terminado en empate");
                gameOver = true;
                gunaGradientButton1.Visible = true;
                gunaGradientButton1.BringToFront();
            }
        }

        // Función que evalúa el estado del tablero y devuelve un valor según el resultado
        // 10 si el jugador gana, -10 si el oponente gana, 0 si hay empate o el juego no ha terminado
        private int Evaluate(int[] board)
        {
            // Revisar las filas
            for (int i = 0; i < 9; i += 3)
            {
                if (board[i] == board[i + 1] && board[i] == board[i + 2])
                {
                    if (board[i] == 1)
                    {
                        return 10;
                    }
                    else if (board[i] == 2)
                    {
                        return -10;
                    }
                }
            }

            // Revisar las columnas
            for (int i = 0; i < 3; i++)
            {
                if (board[i] == board[i + 3] && board[i] == board[i + 6])
                {
                    if (board[i] == 1)
                    {
                        return 10;
                    }
                    else if (board[i] == 2)
                    {
                        return -10;
                    }
                }
            }

            // Revisar las diagonales
            if (board[0] == board[4] && board[4] == board[8])
            {
                if (board[0] == 1)
                {
                    return 10;
                }
                else if (board[0] == 2)
                {
                    return -10;
                }
            }

            if (board[2] == board[4] && board[4] == board[6])
            {
                if (board[2] == 1)
                {
                    return 10;
                }
                else if (board[2] == 2)
                {
                    return -10;
                }
            }

            // Si no hay ganador, devolver 0
            return 0;
        }

        // Función que comprueba si quedan movimientos posibles en el tablero
        private bool IsMovesLeft(int[] board)
        {
            for (int i = 0; i < 9; i++)
            {
                if (board[i] == 0)
                {
                    return true;
                }
            }
            return false;
        }

        // Función que aplica el algoritmo minimax recursivamente y devuelve el mejor movimiento y su valor
        // El parámetro isMax indica si es el turno del jugador que maximiza o minimiza el valor
        private Tuple<int, int> Minimax(int[] board, int depth, bool isMax)
        {
            // Obtener el valor del estado actual del tablero
            int score = Evaluate(board);

            // Si el jugador ha ganado, devolver su valor menos la profundidad
            if (score == 10)
            {
                return Tuple.Create(-1, score - depth);
            }

            // Si el oponente ha ganado, devolver su valor más la profundidad
            if (score == -10)
            {
                return Tuple.Create(-1, score + depth);
            }

            // Si no hay movimientos posibles, devolver cero
            if (!IsMovesLeft(board))
            {
                return Tuple.Create(-1, 0);
            }

            if (board[4] == 0)
            {
                return Tuple.Create(4, 0);
            }

            // Si es el turno del jugador que maximiza el valor
            if (isMax)
            {
                // Inicializar una variable con un valor muy pequeño
                int bestValue = -1000;
                // Inicializar una variable para guardar la mejor casilla
                int bestMove = -1;
                // Recorrer todas las casillas del tablero
                for (int i = 0; i < 9; i++)
                {
                    // Si la casilla está vacía
                    if (board[i] == 0)
                    {
                        // Marcar la casilla con 1
                        board[i] = 1;
                        // Llamar a la función minimax de forma recursiva con el tablero modificado, la profundidad incrementada y el turno invertido
                        int value = Minimax(board, depth + 1, !isMax).Item2;
                        // Desmarcar la casilla para restaurar el estado original del tablero
                        board[i] = 0;
                        // Comparar el valor devuelto por la función recursiva con el mejor valor actual y actualizarlo si es necesario
                        if (value > bestValue)
                        {
                            bestValue = value;
                            bestMove = i;
                        }
                    }
                }
                // Devolver la mejor casilla y el mejor valor como una tupla
                return Tuple.Create(bestMove, bestValue);
            }
            else // Si es el turno del jugador que minimiza el valor
            {
                // Inicializar una variable con un valor muy grande
                int bestValue = 1000;
                // Inicializar una variable para guardar la mejor casilla
                int bestMove = -1;
                // Recorrer todas las casillas del tablero
                for (int i = 0; i < 9; i++)
                {
                    // Si la casilla está vacía
                    if (board[i] == 0)
                    {
                        // Marcar la casilla con 2
                        board[i] = 2;
                        // Llamar a la función minimax de forma recursiva con el tablero modificado, la profundidad incrementada y el turno invertido
                        int value = Minimax(board, depth + 1, !isMax).Item2;
                        // Desmarcar la casilla para restaurar el estado original del tablero
                        board[i] = 0;
                        // Comparar el valor devuelto por la función recursiva con el mejor valor actual y actualizarlo si es necesario
                        if (value < bestValue)
                        {
                            bestValue = value;
                            bestMove = i;
                        }
                    }
                }

                if (turn == 1 && bestMove == 0)
                {
                    int numeros = new Random().Next(0, 4);
                    switch (numeros)
                    {
                        case 0:
                            return Tuple.Create(0, bestValue);
                        case 1:
                            return Tuple.Create(2, bestValue);
                        case 2:
                            return Tuple.Create(6, bestValue);
                        default:
                            return Tuple.Create(8, bestValue);

                    }
                }
                else
                {
                    // Devolver la mejor casilla y el mejor valor como una tupla
                    return Tuple.Create(bestMove, bestValue);
                }
            }
        }

        static async Task PausaAsync(int milisegundos)
        {
            await Task.Delay(milisegundos); // Hace la pausa sin bloquear el hilo
        }

        async private void btnCasilla0_Click(object sender, EventArgs e)
        {
            disableBtns();
            int move = 0;
            int j = 0;
            if (turn % 2 == 0)
            {
                pbCasilla0.Visible = true;
                pbCasilla0.Image = Properties.Resources.Cruz;
                await PausaAsync(400);
                pbCasilla0.Image = Properties.Resources.X_1;
                j = 1;
            }
            else
            {
                pbCasilla0.Visible = true;
                pbCasilla0.Image = Properties.Resources.Circulo;
                await PausaAsync(400);
                pbCasilla0.Image = Properties.Resources.C_1;
                j = 2;
            }
            playerMove(move, j);

            if (!gameOver)
            {
                enableBtns();
            }

        }

        async private void btnCasilla1_Click(object sender, EventArgs e)
        {
            disableBtns();
            int move = 1;
            int j = 0;
            if (turn % 2 == 0)
            {
                pbCasilla1.Visible = true;
                pbCasilla1.Image = Properties.Resources.Cruz;
                await PausaAsync(400);
                pbCasilla1.Image = Properties.Resources.X_1;
                j = 1;
            }
            else
            {
                pbCasilla1.Visible = true;
                pbCasilla1.Image = Properties.Resources.Circulo;
                await PausaAsync(400);
                pbCasilla1.Image = Properties.Resources.C_1;
                j = 2;
            }
            playerMove(move, j);

            if (!gameOver)
            {
                enableBtns();
            }
        }


        async private void btnCasilla2_Click(object sender, EventArgs e)
        {
            disableBtns();
            int move = 2;
            int j = 0;
            if (turn % 2 == 0)
            {
                pbCasilla2.Visible = true;
                pbCasilla2.Image = Properties.Resources.Cruz;
                await PausaAsync(400);
                pbCasilla2.Image = Properties.Resources.X_1;
                j = 1;
            }
            else
            {
                pbCasilla2.Visible = true;
                pbCasilla2.Image = Properties.Resources.Circulo;
                await PausaAsync(400);
                pbCasilla2.Image = Properties.Resources.C_1;
                j = 2;
            }
            playerMove(move, j);

            if (!gameOver)
            {
                enableBtns();
            }
        }


        async private void btnCasilla3_Click(object sender, EventArgs e)
        {
            disableBtns();
            int move = 3;
            int j = 0;
            if (turn % 2 == 0)
            {
                pbCasilla3.Visible = true;
                pbCasilla3.Image = Properties.Resources.Cruz;
                await PausaAsync(400);
                pbCasilla3.Image = Properties.Resources.X_1;
                j = 1;
            }
            else
            {
                pbCasilla3.Visible = true;
                pbCasilla3.Image = Properties.Resources.Circulo;
                await PausaAsync(400);
                pbCasilla3.Image = Properties.Resources.C_1;
                j = 2;
            }
            playerMove(move, j);

            if (!gameOver)
            {
                enableBtns();
            }
        }



        async private void btnCasilla4_Click(object sender, EventArgs e)
        {
            disableBtns();
            int move = 4;
            int j = 0;
            if (turn % 2 == 0)
            {
                pbCasilla4.Visible = true;
                pbCasilla4.Image = Properties.Resources.Cruz;
                await PausaAsync(400);
                pbCasilla4.Image = Properties.Resources.X_1;
                j = 1;
            }
            else
            {
                pbCasilla4.Visible = true;
                pbCasilla4.Image = Properties.Resources.Circulo;
                await PausaAsync(400);
                pbCasilla4.Image = Properties.Resources.C_1;
                j = 2;
            }
            playerMove(move, j);

            if (!gameOver)
            {
                enableBtns();
            }
        }



        async private void btnCasilla5_Click(object sender, EventArgs e)
        {
            disableBtns();
            int move = 5;
            int j = 0;
            if (turn % 2 == 0)
            {
                pbCasilla5.Visible = true;
                pbCasilla5.Image = Properties.Resources.Cruz;
                await PausaAsync(400);
                pbCasilla5.Image = Properties.Resources.X_1;
                j = 1;
            }
            else
            {
                pbCasilla5.Visible = true;
                pbCasilla5.Image = Properties.Resources.Circulo;
                await PausaAsync(400);
                pbCasilla5.Image = Properties.Resources.C_1;
                j = 2;
            }
            playerMove(move, j);

            if (!gameOver)
            {
                enableBtns();
            }
        }



        async private void btnCasilla8_Click(object sender, EventArgs e)
        {
            disableBtns();
            int move = 8;
            int j = 0;
            if (turn % 2 == 0)
            {
                pbCasilla8.Visible = true;
                pbCasilla8.Image = Properties.Resources.Cruz;
                await PausaAsync(400);
                pbCasilla8.Image = Properties.Resources.X_1;
                j = 1;
            }
            else
            {
                pbCasilla8.Visible = true;
                pbCasilla8.Image = Properties.Resources.Circulo;
                await PausaAsync(400);
                pbCasilla8.Image = Properties.Resources.C_1;
                j = 2;
            }
            playerMove(move, j);

            if (!gameOver)
            {
                enableBtns();
            }
        }



        async private void btnCasilla7_Click(object sender, EventArgs e)
        {
            disableBtns();
            int move = 7;
            int j = 0;
            if (turn % 2 == 0)
            {
                pbCasilla7.Visible = true;
                pbCasilla7.Image = Properties.Resources.Cruz;
                await PausaAsync(400);
                pbCasilla7.Image = Properties.Resources.X_1;
                j = 1;
            }
            else
            {
                pbCasilla7.Visible = true;
                pbCasilla7.Image = Properties.Resources.Circulo;
                await PausaAsync(400);
                pbCasilla7.Image = Properties.Resources.C_1;
                j = 2;
            }
            playerMove(move, j);

            if (!gameOver)
            {
                enableBtns();
            }
        }



        async private void btnCasilla6_Click(object sender, EventArgs e)
        {
            disableBtns();
            int move = 6;
            int j = 0;
            if (turn % 2 == 0)
            {
                pbCasilla6.Visible = true;
                pbCasilla6.Image = Properties.Resources.Cruz;
                await PausaAsync(400);
                pbCasilla6.Image = Properties.Resources.X_1;
                j = 1;
            }
            else
            {
                pbCasilla6.Visible = true;
                pbCasilla6.Image = Properties.Resources.Circulo;
                await PausaAsync(400);
                pbCasilla6.Image = Properties.Resources.C_1;
                j = 2;
            }
            playerMove(move, j);

            if (!gameOver)
            {
                enableBtns();
            }
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            nGames++;

            turn = 0;

            for (int i = 0; i < 9; i++)
            {
                board[i] = 0;
            }

            gameOver = false;

            pbCasilla0.Visible = false;
            pbCasilla1.Visible = false;
            pbCasilla2.Visible = false;
            pbCasilla3.Visible = false;
            pbCasilla4.Visible = false;
            pbCasilla5.Visible = false;
            pbCasilla6.Visible = false;
            pbCasilla7.Visible = false;
            pbCasilla8.Visible = false;

            if (isCPUvsCPU)
            {
                btnStart.Visible = true;
            }
            else
            {
                enableBtns();
            }

            gunaGradientButton1.Visible = false;

            if (nGames % 2 != 0 && !isJvsJ && !isCPUvsCPU)
            {
                cpuMove();
            }



        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Visible = false;
            cpuVScpuControl();
        }

        private void disableBtns()
        {
            btnCasilla0.Enabled = false;
            btnCasilla1.Enabled = false;
            btnCasilla2.Enabled = false;
            btnCasilla3.Enabled = false;
            btnCasilla4.Enabled = false;
            btnCasilla5.Enabled = false;
            btnCasilla6.Enabled = false;
            btnCasilla7.Enabled = false;
            btnCasilla8.Enabled = false;
        }

        private void enableBtns()
        {
            btnCasilla0.Enabled = true;
            btnCasilla1.Enabled = true;
            btnCasilla2.Enabled = true;
            btnCasilla3.Enabled = true;
            btnCasilla4.Enabled = true;
            btnCasilla5.Enabled = true;
            btnCasilla6.Enabled = true;
            btnCasilla7.Enabled = true;
            btnCasilla8.Enabled = true;
        }

    }
}
