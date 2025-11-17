namespace Compiler.Nodes
{
    /// <summary>
    /// A node corresponding to a bracket expression
    /// </summary>
    public class BracketExpressionNode : IExpressionNode
    {
        /// <summary>
        /// The expression being performed
        /// </summary>
        public IExpressionNode Expression { get; }

        /// <summary>
        /// The type of the node
        /// </summary>
        public SimpleTypeDeclarationNode Type { get; set; }

        /// <summary>
        /// The position in the code where the content associated with the node begins
        /// </summary>
        public Position Position { get; }

        /// <summary>
        /// Creates a new bracket expression node
        /// </summary>
        /// <param name="expression">The expression the operation is applied to</param>
        public BracketExpressionNode(IExpressionNode expression)
        {
            Expression = expression;
        }
    }
}