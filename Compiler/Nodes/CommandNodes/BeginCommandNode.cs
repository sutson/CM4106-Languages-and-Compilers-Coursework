namespace Compiler.Nodes
{
    /// <summary>
    /// A node corresponding to a begin command
    /// </summary>
    public class BeginCommandNode : ICommandNode
    {
        /// <summary>
        /// The command inside the begin block
        /// </summary>
        public ICommandNode Command { get; }

        /// <summary>
        /// The position in the code where the content associated with the node begins
        /// </summary>
        public Position Position { get; }

        /// <summary>
        /// Creates a new begin node
        /// </summary>
        /// <param name="command">The command inside the begin block</param>
        /// <param name="position">The position in the code where the content associated with the node begins</param>
        public BeginCommandNode(ICommandNode command, Position position)
        {
            Command = command;
            Position = position;
        }
    }
}