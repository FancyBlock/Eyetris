//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18408
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------
using System;

[System.Serializable]
public class Grid3d
{
	public int m_x;
	public int m_y;
	public int m_z;


	/// <summary>
	/// constructor 
	/// </summary>
	public Grid3d ( int x, int y, int z )
	{
		m_x = x;
		m_y = y;
		m_z = z;
	}

    /// <summary>
    /// constructor 
    /// </summary>
    /// <param name="grid"></param>
    public Grid3d( Grid3d grid )
    {
        m_x = grid.m_x;
        m_y = grid.m_y;
        m_z = grid.m_z;
    }

}

