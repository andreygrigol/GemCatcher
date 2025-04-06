using Godot;
using System;

public partial class Gem : Area2D
{
	[Export] float _speed = 110.0f;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		Position += new Vector2(0, _speed * (float)delta);
	}
}
