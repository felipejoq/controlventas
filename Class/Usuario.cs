using System;
using System.Collections.Generic;

public class Usuario
{
    private int _id;
    private string _rut;
    private string _password;
    private static List<Usuario> _listaUsuarios = new List<Usuario>();

    public Usuario(int id, string rut, string password)
    {
        this._id = id;
        this._rut = rut;
        this._password = password;
    }

    public Usuario()
    {

    }

    public int Id
    {
        get { return this._id; }
        set { this._id = value; }
    }

    public string Rut
    {
        get { return this._rut; }
        set { this._rut = value; }
    }

    public string Password
    {
        get { return this._password; }
        set { this._password = value; }
    }

    public static void addUsers(Usuario usuario)
    {
        _listaUsuarios.Add(usuario);
    }

    public static void seeUsers()
    {
        Console.WriteLine("\n***** Lista de usuarios *****");
        foreach (Usuario user in _listaUsuarios)
        {
            Console.WriteLine(user.Id + "). Rut: " + user.Rut + " password: " + user.Password);
        }
    }

}