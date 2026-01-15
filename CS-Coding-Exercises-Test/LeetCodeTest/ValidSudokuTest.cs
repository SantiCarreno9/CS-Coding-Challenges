using LeetCode;

namespace LeetCodeTest;

[TestFixture]
internal class ValidSudokuTest
{

    [Test]
    public void TestOne()
    {
        char[][] board = new char[][] {
            new char[]{'5', '3', '.', '.', '7', '.', '.', '.', '.' },
            new char[]{'6', '.', '.', '1', '9', '5', '.', '.', '.' },
            new char[] {'.', '9', '8', '.', '.', '.', '.', '6', '.'},
            new char[] {'8', '.', '.', '.', '6', '.', '.', '.', '3'},
            new char[] {'4', '.', '.', '8', '.', '3', '.', '.', '1'},
            new char[]{'7', '.', '.', '.', '2', '.', '.', '.', '6'},
            new char[] {'.', '6', '.', '.', '.', '.', '2', '8', '.'},
            new char[] {'.', '.', '.', '4', '1', '9', '.', '.', '5'},
            new char[] {'.', '.', '.', '.', '8', '.', '.', '7', '9'}};

        Assert.That(ValidSudoku.IsValidSudoku(board), Is.True);
    }

    [Test]
    public void TestTwo()
    {
        char[][] board = new char[][] {
            new char[]{'8', '3', '.', '.', '7', '.', '.', '.', '.' },
            new char[]{'6', '.', '.', '1', '9', '5', '.', '.', '.' },
            new char[] {'.', '9', '8', '.', '.', '.', '.', '6', '.'},
            new char[] {'8', '.', '.', '.', '6', '.', '.', '.', '3'},
            new char[] {'4', '.', '.', '8', '.', '3', '.', '.', '1'},
            new char[]{'7', '.', '.', '.', '2', '.', '.', '.', '6'},
            new char[] {'.', '6', '.', '.', '.', '.', '2', '8', '.'},
            new char[] {'.', '.', '.', '4', '1', '9', '.', '.', '5'},
            new char[] {'.', '.', '.', '.', '8', '.', '.', '7', '9'}};

        Assert.That(ValidSudoku.IsValidSudoku(board), Is.False);
    }

    [Test]
    public void TestThree()
    {       
        char[][] board = new char[][] {
            new char[]{'.','.','4','.','.','.','6','3','.' },
            new char[]{'.','.','.','.','.','.','.','.','.' },
            new char[] {'5','.','.','.','.','.','.','9','.'},
            new char[] {'.','.','.','5','6','.','.','.','.'},
            new char[] {'4','.','3','.','.','.','.','.','1'},
            new char[]{'.','.','.','7','.','.','.','.','.'},
            new char[] {'.','.','.','5','.','.','.','.','.'},
            new char[] {'.','.','.','.','.','.','.','.','.'},
            new char[] {'.','.','.','.','.','.','.','.','.'}};

        Assert.That(ValidSudoku.IsValidSudoku(board), Is.False);
    }

}
