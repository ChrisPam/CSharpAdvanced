using System;

class InstructionSet_broken
{
    static void Main()
    {

        string opCode = Console.ReadLine().ToLower();

        while (opCode != "end")
        {
            string[] codeArgs = opCode.ToLower().Split(' ');
            long result = 0;
            switch (codeArgs[0])
            {
                case "inc":
                    {
                        long operandOne = long.Parse(codeArgs[1]);
                        result = operandOne + 1;
                        break;
                    }
                case "dec":
                    {
                        long operandOne = long.Parse(codeArgs[1]);
                        result = operandOne - 1;
                        break;
                    }
                case "add":
                    {
                        long operandOne = long.Parse(codeArgs[1]);
                        long operandTwo = long.Parse(codeArgs[2]);
                        result = operandOne + operandTwo;
                        break;
                    }
                case "mla":
                    {
                        long operandOne = long.Parse(codeArgs[1]);
                        long operandTwo = long.Parse(codeArgs[2]);
                        result = (operandOne * operandTwo);
                        break;
                    }
            }
            Console.WriteLine(result);
            opCode = Console.ReadLine().ToLower();
        }


    }
}