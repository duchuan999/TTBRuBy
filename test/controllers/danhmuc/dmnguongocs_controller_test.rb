require 'test_helper'

class Danhmuc::DmnguongocsControllerTest < ActionController::TestCase
  setup do
    @danhmuc_dmnguongoc = danhmuc_dmnguongocs(:one)
  end

  test "should get index" do
    get :index
    assert_response :success
    assert_not_nil assigns(:danhmuc_dmnguongocs)
  end

  test "should get new" do
    get :new
    assert_response :success
  end

  test "should create danhmuc_dmnguongoc" do
    assert_difference('Danhmuc::Dmnguongoc.count') do
      post :create, danhmuc_dmnguongoc: { stt: @danhmuc_dmnguongoc.stt, ten: @danhmuc_dmnguongoc.ten }
    end

    assert_redirected_to danhmuc_dmnguongoc_path(assigns(:danhmuc_dmnguongoc))
  end

  test "should show danhmuc_dmnguongoc" do
    get :show, id: @danhmuc_dmnguongoc
    assert_response :success
  end

  test "should get edit" do
    get :edit, id: @danhmuc_dmnguongoc
    assert_response :success
  end

  test "should update danhmuc_dmnguongoc" do
    patch :update, id: @danhmuc_dmnguongoc, danhmuc_dmnguongoc: { stt: @danhmuc_dmnguongoc.stt, ten: @danhmuc_dmnguongoc.ten }
    assert_redirected_to danhmuc_dmnguongoc_path(assigns(:danhmuc_dmnguongoc))
  end

  test "should destroy danhmuc_dmnguongoc" do
    assert_difference('Danhmuc::Dmnguongoc.count', -1) do
      delete :destroy, id: @danhmuc_dmnguongoc
    end

    assert_redirected_to danhmuc_dmnguongocs_path
  end
end
