// Dharmin Patel
using System;
using System.Windows.Forms;

public static class Validator
{
    private static string title = "Entry Error";
    public static string Title
    {
        get => title;
        set => title = value;
    }

    public static bool IsPresent(TextBox textBox)
    {
        if (textBox.Text == "")
        {
            MessageBox.Show(textBox.Tag + " is a required field.", Title);
            textBox.Focus();
            return false;
        }
        return true;
    }

    public static bool IsDecimal(TextBox textBox)
    {
        if (decimal.TryParse(textBox.Text, out _))
        {
            return true;
        }
        else
        {
            MessageBox.Show(textBox.Tag + " must be a decimal value.", Title);
            textBox.Focus();
            return false;
        }
    }

    public static bool IsInt32(TextBox textBox)
    {
        if (int.TryParse(textBox.Text, out _))
        {
            return true;
        }
        else
        {
            MessageBox.Show(textBox.Tag + " must be an integer.", Title);
            textBox.Focus();
            return false;
        }
    }
}
