using Godot;
using System;

public partial class Node2d : Node2D
{
	string teste = "";

	int inteiro = 0;

	public override void _Ready(){
		teste = "Deu certo teste test tes";
		GD.Print(teste);
	} 
	public override void _Process(double delta){

	} 
}
