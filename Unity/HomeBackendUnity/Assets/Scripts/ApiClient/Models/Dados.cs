[System.Serializable]
public class Dados
{
    public int DadosID;

    public string Nome;

    public string Descricao;

    public int Poligonos;

    public int Tamanho;

    // Relacionamento Item --> TipoItem
    public int TipoDadosID;
}