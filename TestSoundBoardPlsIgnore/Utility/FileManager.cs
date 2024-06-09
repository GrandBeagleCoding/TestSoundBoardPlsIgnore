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

		public bool GetHttpInputFromUser(string httpLink)
		{
			if (string.IsNullOrEmpty(httpLink)) 
				return false;


			return true;
		}
	}
}
