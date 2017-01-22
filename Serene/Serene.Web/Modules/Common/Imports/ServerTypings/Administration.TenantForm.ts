namespace Serene.Administration {
    export class TenantForm extends Serenity.PrefixedContext {
        static formKey = 'Administration.Tenant';

    }

    export interface TenantForm {
        Name: Serenity.StringEditor;
    }

    [['Name', () => Serenity.StringEditor]].forEach(x => Object.defineProperty(TenantForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

