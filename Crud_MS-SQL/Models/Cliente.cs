using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crud_MS_SQL.Models;


[Table("Cliente")]
public class Cliente
{
    [Column("Id")]
    [Display(Name = "Cógido")]
    public int Id { get; set; }

    [Column("Nome")]
    [Display(Name = "Nome")]
    public string Nome { get; set; }


    [Column("Email")]
    [Display(Name = "Email")]
    public string Email { get; set; }

    [Column("Telefone")]
    [Display(Name = "Telefone")]
    public string Telefone { get; set; }

    [Column("Endereco")]
    [Display(Name = "Endereço")]
    public string Endereco { get; set; }

    [Column("Agendamento")]
    [Display(Name = "Agendamento")]
    public string Agendamento { get; set; }

    [Column("Servico")]
    [Display(Name = "Serviço")]
    public string Servico { get; set; }
}
