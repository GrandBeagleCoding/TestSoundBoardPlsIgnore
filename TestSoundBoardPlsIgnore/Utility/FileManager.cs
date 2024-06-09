using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSoundBoardPlsIgnore.Utility
{
	//TODO: Implement File Handler Class for handling all interactions with files
	public class FileManager
	{
		public FileManager()
		{
		   
		}

		public bool GetHttpInputFromUser(string _httpLink)
		{
			if (string.IsNullOrEmpty(_httpLink)) 
				return false;


			return true;
		}
	}
}
