using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GCook.Models;

[Table("Comentario")]
    public class Comentario
    {
        [Key]
        public int Id { get; set; }

        public int IngredienteId { get; set; }
        [Required(ErrorMessage = "A Quantidade é obrigatória")]
        [ForeignKey("ReceitaId")]
        public Receita Receita { get; set; }

        [Required(ErrorMessage = "O Usuário é obrigatório")]
        public string UsuarioId { get; set; }
        [ForeignKey("UsuarioId")]
        public Usuario Usuario { get; set; }

        [Display(Name = "Data de Comentário")]
        [Required(ErrorMessage = "A Data do Comentário é obrigatória")]
        public DateTime DataComentario { get; set; }
        [StringLength(300)]
        [Display(Name = "O Texto é Comentário")]
        [Required(ErrorMessage = "O Texto é obrigatório")]
        public string TextoComentario { get; set; }        
    }
