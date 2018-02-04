using System;
using FinAssist.BaseLib;
using FinAssist.Model;
using FinAssist.Model.Repositories;

namespace FinAssist.Controllers
{
	public class MainFormController : IMainFormController
	{
		private bool _defaultModelLoaded = false;

		private readonly IWindowFormsFactory	_formsFactory = null;
		private readonly IAccountRepository		_accountRepository = null;

		public MainFormController(IWindowFormsFactory inFormFactory, IAccountRepository inAccountRepo)
		{
			_formsFactory = inFormFactory;
			_accountRepository = inAccountRepo;
		}
		public void LoadDefaultModel()
		{
			if (_defaultModelLoaded == false)
			{
				_accountRepository.addAccount(new CurrentAccount(1, "Tekući račun", 0.0F));
				_accountRepository.addAccount(new CashAccount(2, "Gotovina", 100.0F));
				_accountRepository.addAccount(new CreditCardAccount(3, "MasterCard kartica", -1000.0F));
				_accountRepository.addAccount(new IncomeSourceAccount(4, "Plaća"));

				//_expPlaceRep.AddExpenditurePlace(new ExpenditurePlace("Zagreb"));

				//_expCatRep.AddExpenditureCategory("Prehrana", null);
				//_expCatRep.AddExpenditureCategory("Auto", null);
				//_expCatRep.AddExpenditureCategory("Knjige", null);
				//_expCatRep.AddExpenditureCategory("Troškovi djeca", null);
				//_expCatRep.AddExpenditureCategory("Komunalije", null);

				//Transaction tr1 = new Transaction(7998,
				//									DateTime.Now,
				//									_accRep.getAccountByName("Plaća"),
				//									_accRep.getAccountByName("Tekući račun"),
				//									new IncomeTransDescription("Došla plaća za 11. mjesec")
				//								  );

				//_transRep.AddTransaction(tr1);

				_defaultModelLoaded = true;
			}
		}

		public void AddAccount()
		{
			var accController = new AccountController();

			var newFrm = _formsFactory.CreateAddNewAccountView(accController.getAccountTypesList());

			accController.AddNewAccount(newFrm, _accountRepository);
		}

		public void ShowAccounts()
		{
			var accController = new AccountController();

			var newFrm = _formsFactory.CreateShowAccountsListView();

			accController.ViewAccounts(newFrm, _accountRepository, this);
		}

		public void AddExpenditureTransaction()
		{
		}

		public void AddIncomeTransaction()
		{
		}

		public void AddTransferTransaction()
		{
		}

		public void ShowSummaryReport()
		{
		}

		public void ShowTransactions()
		{
		}

		public void ShowExpenditureCategories()
		{
		}

		public void ShowExpenditurePlaces()
		{
		}
	}
}
