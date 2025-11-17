namespace Compiler.Nodes
{
    /// <summary>
    /// A node corresponding to an unless command
    /// </summary>
    public class UnlessCommandNode : ICommandNode
    {
        /// <summary>
        /// The condition associated with the loop
        /// </summary>
        public IExpressionNode Expression { get; }

        /// <summary>
        /// The command inside the loop
        /// </summary>
        public ICommandNode Command { get; }

        /// <summary>
        /// The position in the code where the content associated with the node begins
        /// </summary>
        public Position Position { get; }

        /// <summary>
        /// Creates a new unless node
        /// </summary>
        /// <param name="expression">The condition associated with the loop</param>
        /// <param name="command">The command inside the loop</param>
        /// <param name="position">The position in the code where the content associated with the node begins</param>
        public UnlessCommandNode(IExpressionNode expression, ICommandNode command, Position position)
        {
            Expression = expression;
            Command = command;
            Position = position;
        }
    }
}