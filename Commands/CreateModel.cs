using System;
using Rhino;
using Rhino.Commands;
using AIM.Core;

namespace AIM.RH.Commands
{
    public class CreateModel : Command
    {
        static CreateModel _instance;
        public CreateModel()
        {
            _instance = this;
        }

        ///<summary>The only instance of the CreateModel command.</summary>
        public static CreateModel Instance
        {
            get { return _instance; }
        }

        public override string EnglishName
        {
            get { return "CreateModel"; }
        }

        protected override Result RunCommand(RhinoDoc doc, RunMode mode)
        {
            // TODO: complete command.

            Transformation t = new Transformation();


            return Result.Success;
        }
    }
}