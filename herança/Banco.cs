/*No banco XX, os clientes podem criar contas bancárias. Cada conta possui os
atributos: número da conta, agência, titular da conta (apenas o nome), saldo da conta.
Além disso, as contas possuem as operações de saque (que verifica se há saldo
suficiente) e depósito. O banco possui dois tipos de contas diferenciadas, conta para
estudante e conta para empresa*/public class Banco
{
    private string numConta;
    private string agencia;
    private string nome;
    private double saldo;

    public void GetDeposito(double _deposito)
    {
        this.saldo = _deposito;
    }
    public double SetSaque(double _saque)
    {
        if(_saque <= this.saldo)
        {
            _saque -= this.saldo;
        }
    }


}