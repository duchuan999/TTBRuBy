Rails.application.routes.draw do

  scope ":locale", locale: /#{I18n.available_locales.join("|")}/ do
    root to: 'pages#home'
    resources :dmnhomnuocsxes do
      get "delete"
    end
    resources :dmnhomins do
      get "delete"
    end
    resources :dmnuocsxes do
      get "delete"
    end
    resources :dmnhombcs do
      get "delete"
    end
    resources :dmnhomhangsxes do
      get "delete"
    end
    resources :dmnhomnhaccs do
      get "delete"
    end
    resources :dmhangsxes do
      get "delete"
    end
    resources :dmnhaccs do
      get "delete"
    end
    resources :dmnguons do
      get "delete"
    end
    resources :dmnhoms do
      get "delete"
    end
    resources :dmkhos do
      get "delete"
    end
    resources :dmdvts do
      get "delete"
    end
    resources :dmphieus do
      get "delete"
    end
    get 'pages/about'

  end
  match '*path', to: redirect("/#{I18n.default_locale}/%{path}"), :via => [:get, :post]
  match '', to: redirect("/#{I18n.default_locale}"), :via => [:get, :post]
end
