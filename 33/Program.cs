int n = 0;

int[,]spiral = new int [,]


{
{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
{0,1,1,1,1,1,1,1,1,1,1,1,1,1,0},
{0,1,1,1,1,1,1,1,1,1,1,1,1,1,0},
{0,1,1,1,1,1,1,1,1,1,1,1,1,1,0},
{0,1,1,1,1,1,1,1,1,1,1,1,1,1,0},
{0,1,1,1,1,1,1,1,1,1,1,1,1,1,0},
{0,1,1,1,1,1,1,1,1,1,1,1,1,1,0},
{0,1,1,1,1,1,1,1,1,1,1,1,1,1,0},
{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},

};

void PrintMatrix (int[,] matr)
{

    for (int i = 0; i < matr.GetLength (0); i++)

    {
    for (int j = 0; j < matr.GetLength (1); j++)

        {
            //Console.Write($"{matr[i,j]} ");
            if(matr[i,j] == 0) Console.Write($"-");
            else Console.Write($"{n++} ");
    
        }
    Console.WriteLine();

    }

}

void FillMatrix (int row, int col)

{

if(spiral[row,col] == n)

{
spiral[row,col] = 1;
FillMatrix (row, col+1);
FillMatrix (row+1, col);
FillMatrix (row, col-1);
FillMatrix (row-1, col);

}

}



FillMatrix(1, 1);
PrintMatrix(spiral);



