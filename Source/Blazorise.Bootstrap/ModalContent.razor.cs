﻿#region Using directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
#endregion

namespace Blazorise.Bootstrap.BootstrapBase
{
    public abstract class BaseBootstrapModalContent : BaseModalContent
    {
        #region Members

        #endregion

        #region Methods

        protected override void BuildClasses( ClassBuilder builder )
        {
            DialogClassMapper
                .Add( () => $"modal-dialog {ClassProvider.ToModalSize( Size )}" )
                .If( () => ClassProvider.ModalContentCentered(), () => IsCentered );

            base.BuildClasses( builder );
        }

        protected override void DirtyClasses()
        {
            DialogClassMapper.Dirty();
        }

        #endregion

        #region Properties

        /// <summary>
        /// Dialog container classname.
        /// </summary>
        protected ClassMapper DialogClassMapper { get; } = new ClassMapper();

        #endregion
    }
}
