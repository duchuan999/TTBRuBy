require 'test_helper'

class DmhangsxesControllerTest < ActionController::TestCase
  setup do
    @dmhangsx = dmhangsxes(:one)
  end

  test "should get index" do
    get :index
    assert_response :success
    assert_not_nil assigns(:dmhangsxes)
  end

  test "should get new" do
    get :new
    assert_response :success
  end

  test "should create dmhangsx" do
    assert_difference('Dmhangsx.count') do
      post :create, dmhangsx: { stt: @dmhangsx.stt, ten: @dmhangsx.ten }
    end

    assert_redirected_to dmhangsx_path(assigns(:dmhangsx))
  end

  test "should show dmhangsx" do
    get :show, id: @dmhangsx
    assert_response :success
  end

  test "should get edit" do
    get :edit, id: @dmhangsx
    assert_response :success
  end

  test "should update dmhangsx" do
    patch :update, id: @dmhangsx, dmhangsx: { stt: @dmhangsx.stt, ten: @dmhangsx.ten }
    assert_redirected_to dmhangsx_path(assigns(:dmhangsx))
  end

  test "should destroy dmhangsx" do
    assert_difference('Dmhangsx.count', -1) do
      delete :destroy, id: @dmhangsx
    end

    assert_redirected_to dmhangsxes_path
  end
end
