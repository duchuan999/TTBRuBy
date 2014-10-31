require 'test_helper'

class DmkhosControllerTest < ActionController::TestCase
  setup do
    @dmkho = dmkhos(:one)
  end

  test "should get index" do
    get :index
    assert_response :success
    assert_not_nil assigns(:dmkhos)
  end

  test "should get new" do
    get :new
    assert_response :success
  end

  test "should create dmkho" do
    assert_difference('Dmkho.count') do
      post :create, dmkho: { dmloaikho_id: @dmkho.dmloaikho_id, stt: @dmkho.stt, ten: @dmkho.ten }
    end

    assert_redirected_to dmkho_path(assigns(:dmkho))
  end

  test "should show dmkho" do
    get :show, id: @dmkho
    assert_response :success
  end

  test "should get edit" do
    get :edit, id: @dmkho
    assert_response :success
  end

  test "should update dmkho" do
    patch :update, id: @dmkho, dmkho: { dmloaikho_id: @dmkho.dmloaikho_id, stt: @dmkho.stt, ten: @dmkho.ten }
    assert_redirected_to dmkho_path(assigns(:dmkho))
  end

  test "should destroy dmkho" do
    assert_difference('Dmkho.count', -1) do
      delete :destroy, id: @dmkho
    end

    assert_redirected_to dmkhos_path
  end
end
