using UnityEditor;
using UnityEngine;

namespace Kogane.Internal
{
    internal static class RenameGameObjectMenuItem
    {
        [MenuItem( "CONTEXT/Component/Rename Game Object" )]
        private static void Rename( MenuCommand menuCommand )
        {
            var type       = menuCommand.context.GetType();
            var name       = type.Name;
            var component  = ( Component )menuCommand.context;
            var gameObject = component.gameObject;

            Undo.RecordObject( gameObject, "Rename" );

            gameObject.name = name;
        }
    }
}