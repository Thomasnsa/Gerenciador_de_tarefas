using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Gerenciador_de_tarefas.Models;

[Table("USUARIO")]
public partial class Usuario
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("NOME")]
    [StringLength(150)]
    public string Nome { get; set; } = null!;

    [Column("EMAIL")]
    [StringLength(150)]
    public string Email { get; set; } = null!;

    [Column("NASCIMENTO", TypeName = "datetime")]
    public DateTime Nascimento { get; set; }
}
