namespace POO_Interfaces.classes
{
    public interface ICarrinho
    {
         //Criamos uma espécie de "Contrato" para deixar obrigatório
         // a implementação de todos os método e estruturas que herdarem essa interface
         
         //CRUD

       
        //Creat = Criar
         void Cadastrar(Produto produto);

        //Read = Ler
         void Listar();


        //Update = Alterar
         void Alterar(int _cod, Produto produto);

        //Deletar = Apagar/Deletar
         void Deletar(Produto produto);
    }
}