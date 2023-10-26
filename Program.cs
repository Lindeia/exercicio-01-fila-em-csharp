class Program
{
    static Queue<Cliente> filaAtendimento = new Queue<Cliente>();
    static List<Funcionario> funcionarios = new List<Funcionario>();

    static Random random = new Random();

    static void Main()
    {
        // Adicione alguns funcionários à lista
        funcionarios.Add(new Funcionario("Funcionário 1"));
        funcionarios.Add(new Funcionario("Funcionário 2"));
        funcionarios.Add(new Funcionario("Funcionário 3"));

        // Simule a entrada de clientes na fila
        for (int i = 1; i <= 10; i++)
        {
            var cliente = new Cliente($"Cliente {i}");
            filaAtendimento.Enqueue(cliente);
        }

        // Realize o atendimento e registre o tempo de espera
        while (filaAtendimento.Count > 0)
        {
            var cliente = filaAtendimento.Dequeue();
            var funcionario = funcionarios[random.Next(funcionarios.Count)];

            int tempoAtendimento = random.Next(1, 11); // Tempo de atendimento aleatório

            Console.WriteLine($"{cliente.Nome} está sendo atendido por {funcionario.Nome}. Tempo de atendimento: {tempoAtendimento} minutos.");

            // Registre o tempo de espera
            int tempoEspera = random.Next(1, 21); // Tempo de espera aleatório
            Console.WriteLine($"Tempo de espera de {cliente.Nome}: {tempoEspera} minutos");
        }

        Console.WriteLine("Todos os clientes foram atendidos.");
    }
}
