﻿namespace MeuLivroDeReceitas.Domain.Entidades;

public class Usuario : EntitadeBase
{
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Senha { get; set; }
    public string Telefone { get; set; }
}
