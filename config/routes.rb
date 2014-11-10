Rails.application.routes.draw do

  namespace :admin do
  get 'nhaplls/index'
  end



  namespace :admin do
  get 'nhaplls/edit'
  end



  namespace :admin do
  get 'nhaplls/delete'
  end

  scope ":locale", locale: /#{I18n.available_locales.join("|")}/ do
    root to: 'pages#home'
    match '/danhsachttb' => 'pages#danhsachttb', :via => :get, :format => :json
    match '/find_ttb' => 'pages#find_ttb', :via => :get, :format => :json
    namespace :admin do
      match "/" => "general#index", :via => [:get, :post]

      resources :nhapkhos
      resources :nhaplls do
        get "delete"
      end
      resources :nhapcts

    end

    namespace :danhmuc do

      match "/" => "page#index", :via => [:get, :post]

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
      resources :dmttbs do
        get "delete"
      end
      resources :dmnguongocs do
        get "delete"
      end
      resources :dmtinhtrangs do
        get "delete"
      end
      resources :dmnoiscs do
        get "delete"
      end
      resources :dmlydoxuats do
        get "delete"
      end

      resources :dmlydohoantras do
        get "delete"
      end
    end
    get 'pages/about'

  end
  match '*path', to: redirect("/#{I18n.default_locale}/%{path}"), :via => [:get, :post]
  match '', to: redirect("/#{I18n.default_locale}"), :via => [:get, :post]
end
