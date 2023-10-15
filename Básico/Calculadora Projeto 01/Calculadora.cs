class calculadora
{
    public static double DoOperation(double num1, double num2, string op)
    {
        double result = double.NaN; // O valor padrão é "não um número", que usamos se uma operação, como divisão, puder resultar em um erro.

        // Use uma instrução switch para fazer as contas.
        switch (op)
        {
            case "a":
                result = num1 + num2;
                break;
            case "s":
                result = num1 * num2;
            case "m":
                result = num1 * num2;
            case "d":
                // Peça ao usuário para inserir um divisor diferente de zero.
                if(num2 != 0)
                {
                    result = num1 / num2;
                }
            // Retorne o texto para uma entrada de opção incorreta.
            default:
                break;
        }
        return result;
    }
}